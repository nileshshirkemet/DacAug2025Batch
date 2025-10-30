using DemoApp.Shopping.Data;
using Microsoft.EntityFrameworkCore;
using Sales;

var db = new DbContextOptionsBuilder<ShopDbContext>();
if(args.Length > 1 && args[1] == "server")
    db.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False");
else
    db.UseSqlite("Data Source=shop.db");
using var shop = new ShopDbContext(db.Options);
int pno = int.Parse(args[0]);
var product = shop.Products.Find(pno);
if(product is null)
{
    foreach(var entry in shop.Products)
        Console.WriteLine("{0, -6}{1, 12:0.00}", entry.Id, entry.Price);
}
else
{
    shop.Entry(product).Collection(p => p.Orders).Load(); //explicit loading of child entities
    Console.WriteLine("Total Sales: {0:0.00}", product.GetTotalSales());
}

