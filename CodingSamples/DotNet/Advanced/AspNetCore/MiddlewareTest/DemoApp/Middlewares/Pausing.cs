namespace DemoApp.Middlewares;

public class Pausing(RequestDelegate next)
{
    private int recent = 0;
    
    public async Task Invoke(HttpContext context)
    {
        int current = Environment.TickCount;
        if(current - recent > 3000)
        {
            await next.Invoke(context);
            recent = current;
        }
        else
        {
            context.Response.StatusCode = 503; //server busy
        }
    }
}