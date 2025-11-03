global using OrderManagerProxy = Sales.OrderManager.OrderManagerClient;
using ServerApp.Resources;
using ServerApp.Security;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpcClient<OrderManagerProxy>(
    channel => channel.Address = new Uri("http://localhost:4030")
);
builder.Services.AddAuthentication()
    .AddJwtBearer(options => JwtHelper.ValidateToken(options));
builder.Services.AddAuthorization();
//web-browser only allows client-side script that originates from
//a given endpoint to consume resources exchanged by the same
//endpoint (same origin policy) or from another endpoint which
//permits cross-origin resource sharing (CORS) by sending 
//required headers
builder.Services.AddCors();
var app = builder.Build();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
//Mapping ASP.NET core minimal APIs
var rest = app.MapGroup("/api/sales");
rest.MapGet("/{customerId}", OrderManagerApi.ReadOrders)
    .RequireAuthorization();
rest.MapPost("/", OrderManagerApi.CreateOrder)
    .RequireAuthorization();
rest.MapGet("/{id}/{passcode}", SalesAgentApi.SignIn);
rest.RequireCors(permissions => permissions
    .WithOrigins("http://localhost:5001")
    .AllowAnyMethod()
    .AllowAnyHeader()
);
app.Run();
