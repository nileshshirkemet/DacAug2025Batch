using DemoApp.Models;

string item = args[0].ToLower();
int quantity = int.Parse(args[1]);
var model = new ShopModel(args[2]);
var info = await model.FetchItemInfoAsync(item);
if(quantity <= info.Stock)
    Console.WriteLine("Total Payment: {0:0.00}", 1.05 * quantity * info.Cost);
else
    Console.WriteLine("Not available!");
