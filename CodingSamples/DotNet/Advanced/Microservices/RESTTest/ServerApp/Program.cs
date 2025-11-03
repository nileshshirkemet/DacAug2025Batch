global using OrderManagerProxy = Sales.OrderManager.OrderManagerClient;
using ServerApp.Resources;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpcClient<OrderManagerProxy>(
    channel => channel.Address = new Uri("http://localhost:4030")
);
var app = builder.Build();
//Mapping ASP.NET core minimal APIs
var rest = app.MapGroup("/api/sales");
rest.MapGet("/{customerId}", OrderManagerApi.ReadOrders);
rest.MapPost("/", OrderManagerApi.CreateOrder);
app.Run();
