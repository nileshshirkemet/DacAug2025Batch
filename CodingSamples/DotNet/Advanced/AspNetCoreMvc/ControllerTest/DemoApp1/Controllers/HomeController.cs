using DemoApp.Tourism.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class HomeController(SiteModel model) : Controller
{
    public IActionResult Index()
    {
        var visitors = model.GetVisitors();
        return View(visitors); //renders ~/Views/Home/Index.cshtml
    }

    public IActionResult Register()
    {
        return View(); //renders ~/Views/Home/Register.cshtml
    }

    [HttpPost]
    public IActionResult Register(string visitorName, int visitorRating)
    {
        model.HandleVisit(visitorName, visitorRating);
        return RedirectToAction("Index");
    }
}
