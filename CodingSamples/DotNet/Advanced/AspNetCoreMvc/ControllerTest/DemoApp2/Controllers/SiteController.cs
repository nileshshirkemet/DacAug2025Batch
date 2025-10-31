using DemoApp.Tourism.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

[ApiController]
[Route("/api/feedbacks")]
public class SiteController : ControllerBase
{
    [HttpGet("{high=5}")]
    public IActionResult ReadVisitors(SiteModel model, int high)
    {
        var visitors = model.GetVisitors()
            .Where(v => v.Stars.Length <= high);
        if(visitors.Any())
            return Ok(visitors);
        return NotFound();
    }

    [HttpPut]
    public IActionResult WriteVisitor(Feedback input, SiteModel model)
    {
        model.HandleVisit(input.Person, input.Rating);
        return Ok();
    }
}
