using System.Xml.Linq;

var doc = XElement.Load("suppliers.xml");
var selection = from e in doc.Elements("Supplier")
    select new 
    {
        Name = e.Attribute("Id").Value,
        Item = e.Element("Component").Value,
        Quantity = (int)e.Element("Stock")
    };
if (args.Length == 0)
{
    foreach(var entry in selection.OrderBy(s => s.Name))
    {
        Console.WriteLine("{0, -12}{1, -12}{2, 8}", entry.Name, entry.Item, entry.Quantity);
    }
}
else
{
    int total = selection.Where(s => s.Item == args[0]).Sum(s => s.Quantity);
    Console.WriteLine("Total supply for {0} is {1}", args[0], total);
}