using DemoApp.Services;

namespace DemoApp.Handlers;

public class Greeting
{

    public static async Task Welcome(HttpResponse response)
    {
        await response.WriteAsync($"""
        <html>
            <head>
                <title>DemoApp</title>
            </head>
            <body>
                <h1>Welcome Visitor</h1>
                <p>
                    <b>Current Time: </b>{DateTime.Now}
                </p>
                <form action="Login" method="POST">
                    <b>Name: </b>
                    <input type="text" name="person"/>
                    <input type="submit" value="Greet"/>
                </form>
            </body>
        </html>
        """);
    }

    public static async Task Hello(HttpRequest request, HttpResponse response, IVisitCounter counting)
    {
        string name = request.Form["person"];
        if(name.Length == 0)
            name = "Idiot";
        await response.WriteAsync($"""
        <html>
            <head>
                <title>DemoApp</title>
            </head>
            <body>
                <h1>Hello {name}</h1>
                <p>
                    <b>Number of Greetings: </b>{counting.CountNext(name)}
                </p>
            </body>
        </html>
        """);
    }

}