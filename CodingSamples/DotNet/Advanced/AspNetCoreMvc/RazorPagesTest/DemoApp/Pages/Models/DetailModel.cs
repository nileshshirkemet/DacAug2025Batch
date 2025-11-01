using DemoApp.Shopping.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Pages.Models;

public class DetailModel(ShopDbContext shop) : PageModel
{
    public List<Order> Invoice { get; set; }

    public async Task OnGetAsync()
    {
        Invoice = await shop.Orders
            .Where(e => e.CustomerId == User.Identity.Name)
            .ToListAsync();
    }

    public async Task<IActionResult> OnGetLogoutAsync()
    {
        await HttpContext.SignOutAsync();
        return RedirectToPage("Index");
    }
}