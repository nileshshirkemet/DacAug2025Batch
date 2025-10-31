using System.ComponentModel.DataAnnotations;

namespace DemoApp.Controllers;

public class Feedback
{
    [Required]
    public string Person { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }
}

