using System.Security.Claims;
using Grpc.Core;
using Grpc.Core.Utils;
using Sales;

namespace ServerApp.Resources;

public class OrderManagerApi
{
    public static async Task<IResult> ReadOrders(string customerId, OrderManagerProxy remote)
    {
        var request = new CustomerInput { CustomerCode = customerId };
        using var reply = remote.FetchOrders(request);
        var resources = from message in await reply.ResponseStream.ToListAsync()
            select new OrderEntry 
            {
                ProductNo = message.ItemCode,
                Quantity = message.ItemCount,
                OrderDate = message.ConfirmationDate
            };
        if(resources.Any())
            return Results.Ok(resources);
        return Results.NotFound();
    }

    public static async Task<IResult> CreateOrder(OrderEntry resource, OrderManagerProxy remote, ILogger<OrderManagerApi> logging, ClaimsPrincipal user)
    {
        var request = new OrderInput 
        {
            CustomerCode = resource.CustomerId,
            ItemCode = resource.ProductNo,
            ItemCount = resource.Quantity
        }; 
        try
        {
            var reply = await remote.PlaceOrderAsync(request);
            if(user != null)
                logging.LogInformation("Order {a} placed by {b}", reply.ConfirmationCode, user.Identity.Name);
            return Results.Ok(resource with { OrderNo = reply.ConfirmationCode });
        }
        catch(RpcException ex)
        {
            return Results.Problem(ex.Status.Detail, "CreateOrder", 500);
        }
    }
}
