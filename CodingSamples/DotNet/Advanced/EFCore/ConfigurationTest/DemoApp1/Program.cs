using DemoApp.Shopping.Data;
using Microsoft.EntityFrameworkCore;

using var shop = new ShopDbContext();
if(args.Length == 0)
{
    foreach(var entry in shop.Customers)
        Console.WriteLine("{0, -8}{1, 12:0.00}", entry.Id, entry.Credit);
}
else
{
    var customer = shop.Customers
        .Include(e => e.Orders) //eager loading of child entities
        .Where(e => e.Id == args[0])
        .FirstOrDefault();
    if(customer is not null)
    {
        foreach(var entry in customer.Orders)
           Console.WriteLine("{0}\t{1}\t{2:yyyy-MM-dd}", entry.ProductId, entry.Quantity, entry.OrderDate);
    }
    else
        Console.WriteLine("No such customer!");
}