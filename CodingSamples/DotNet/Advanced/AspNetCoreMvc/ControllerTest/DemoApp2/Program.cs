using DemoApp.Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //enable MVC without views
builder.Services.AddScoped<SiteModel>();
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
//map actions of a controllers using their attributes
app.MapControllers();
app.Run();
