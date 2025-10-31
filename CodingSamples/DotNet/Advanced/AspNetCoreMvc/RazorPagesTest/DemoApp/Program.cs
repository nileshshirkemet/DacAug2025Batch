using DemoApp.Services;
using DemoApp.Shopping.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); //enable razor pages
builder.Services.AddTransient<IVisitCounter, UniversalCounter>();
//enabling authentication this also automatically adds authentication
//(verifying identity) and authorization (granting permissions)
//middlewares
builder.Services.AddAuthentication()
    .AddCookie(options => options.LoginPath = "/Index");
builder.Services.AddDbContext<ShopDbContext>(
    options => options.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False")
);
var app = builder.Build();
//map a handler for rendering each ~/Pages/X.cshtml to
//the path indicated by its @page directive or to /X
//if this directive does not specify any path using
//X=Index as default
app.MapRazorPages();
app.Run();
