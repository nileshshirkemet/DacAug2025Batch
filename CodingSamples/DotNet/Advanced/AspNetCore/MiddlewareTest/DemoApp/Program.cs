using DemoApp.Handlers;
using DemoApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => 
{
    options.IdleTimeout = TimeSpan.FromMinutes(5);
}); //enable sessions
var app = builder.Build();
app.UseSession();
app.UseStaticFiles();
app.UseMiddleware<Pausing>();
app.MapGet("/Home/{name=Visitor}", Greeting.Welcome);
app.MapPost("/Login", Greeting.Hello);
app.Run();
