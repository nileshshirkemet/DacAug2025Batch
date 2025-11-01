using System.ComponentModel;
using System.Security.Claims;
using DemoApp.Shopping.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoApp.Pages.Models;

public class IndexModel(ShopDbContext shop) : PageModel
{
    [BindProperty]
    public Customer Login { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        int count = await shop.Customers
            .CountAsync(e => e.UserName == Login.UserName && e.Password == Login.Password);
        if(count == 1)
        {
            var identity = new ClaimsIdentity("customer");
            identity.AddClaim(new Claim(ClaimTypes.Name, Login.UserName));
            await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return RedirectToPage("Detail");
        }
        else
        {
            ModelState.AddModelError("Login", "Invalid Customer ID or Password");
            return Page();
        }
    }

}