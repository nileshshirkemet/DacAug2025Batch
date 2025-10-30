using DemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class GreetingController : Controller
{
    //GET request for path Greeting/Clock will be handled by this method
    public IActionResult Clock()
    {
        return Content(DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss"));
    }

    public IActionResult Greet([FromServices] IVisitCounter counting, string id = "Guest")
    {
        var info = new 
        {
            VisitorName = id,
            VisitCount = counting.CountNext(id)
        };
        string browser = Request.Headers.UserAgent;
        if(browser.Contains("Mobile"))
            return View("~/Views/Hello.cshtml", info);
        return View("~/Views/Welcome.cshtml", info);
    }
}