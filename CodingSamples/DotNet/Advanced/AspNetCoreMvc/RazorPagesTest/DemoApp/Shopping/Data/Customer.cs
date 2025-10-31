using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Shopping.Data;

[Table("CustomerInfo"), PrimaryKey(nameof(UserName))]
public class Customer
{
    public string UserName { get; set; }

    public string Password { get; set; }
}