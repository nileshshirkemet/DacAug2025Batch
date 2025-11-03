using Grpc.Core;
using Grpc.Core.Utils;
using Sales;
using ServerApp.Data.Shopping;

namespace ServerApp.Services;

public class OrderManagerService(ShopDbContext shop, ILogger<OrderManagerService> logging) : OrderManager.OrderManagerBase
{
    public override async Task<OrderStatus> PlaceOrder(OrderInput request, ServerCallContext context)
    {
        var ctr = await shop.Counters.FindAsync("order");
        var order = new Order 
        {
            OrderNo = ++ctr.CurrentValue + ctr.SeedValue,
            OrderDate = DateOnly.FromDateTime(DateTime.Now),
            CustomerId = request.CustomerCode,
            ProductNo = request.ItemCode,
            Quantity = request.ItemCount
        };
        shop.Orders.Add(order);
        try
        {
            await shop.SaveChangesAsync();
            return new OrderStatus { ConfirmationCode = order.OrderNo };
        }
        catch(Exception ex)
        {
            logging.LogError(ex, "Order Failed");
            context.Status = new Status(StatusCode.Internal, "Order Failed");
            return new OrderStatus { ConfirmationCode = -1 };
        }
    }

    public override async Task FetchOrders(CustomerInput request, IServerStreamWriter<CustomerOrder> responseStream, ServerCallContext context)
    {
        var messages = from entity in shop.Orders
            where entity.CustomerId == request.CustomerCode
            select new CustomerOrder 
            {
                ItemCode = entity.ProductNo,
                ItemCount = entity.Quantity,
                ConfirmationDate = entity.OrderDate.ToString("yyyy-MM-dd")
            };
        await responseStream.WriteAllAsync(messages);
    }

}

