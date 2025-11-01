using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Shopping;
using ServerApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc(); //enable gRPC
builder.Services.AddDbContext<ShopDbContext>(
    options => options.UseSqlServer("Data Source=iitdac.met.edu;Database=shop;User Id=dac;Password=Dac@1234;Encrypt=False")
);
var app = builder.Build();
//configure Kestrel to use HTTP/2 endpoint (see appsettings.json)
app.MapGrpcService<OrderManagerService>();
app.Run();
