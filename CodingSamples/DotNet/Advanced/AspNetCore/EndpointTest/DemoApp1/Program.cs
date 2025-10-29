using DemoApp.Handlers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/Count", Greeting.Ticks);
app.MapGet("/Home", Greeting.Welcome);
app.MapPost("/Login", Greeting.Hello);
app.Run();
