using DemoApp.Services;
using DemoApp.Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //enable full MVC
builder.Services.AddSingleton<IVisitCounter, PersonalCounter>();
//scoped lifetime activates a new service object for each request
builder.Services.AddScoped<SiteModel>();
var app = builder.Build();
//for each action method Y exposed by a class XController derived
//from Controller class in the current project, map path /X/Y to 
//this method with X=Home and Y=Index by default
app.MapDefaultControllerRoute();
app.Run();
