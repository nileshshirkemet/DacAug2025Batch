namespace DemoApp.Handlers;

public class Greeting
{
    public static async Task Welcome(HttpContext context, string name)
    {
        await context.Response.WriteAsync($"""
        <html>
            <head>
                <title>DemoApp</title>
            </head> 
            <body>
                <h1>Welcome {name}</h1>
                <p>
                    <b>Current Time: </b>{DateTime.Now}
                </p>
            </body>
        </html>
        """);
    }

    public static async Task Hello(HttpContext context)
    {
        string name = context.Request.Form["person"];
        if(name.Length == 0)
            name = "Guest";
        int count = context.Session.GetInt32(name) ?? 0;
        context.Session.SetInt32(name, ++count);
        await context.Response.WriteAsync($"""
        <html>
            <head>
                <title>DemoApp</title>
            </head> 
            <body>
                <h1>Hello {name}</h1>
                <p>
                    <b>Number of Greetings: </b>{count}
                </p>
            </body>
        </html>
        """);
    }
}
