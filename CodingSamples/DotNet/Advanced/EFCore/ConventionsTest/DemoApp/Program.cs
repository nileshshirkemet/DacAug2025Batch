using DemoApp.Tourism.Models;

var model = new SiteModel();
if(args.Length > 0)
{
    model.HandleVisit(args[0], 5);
    Console.WriteLine("Welcome {0}", args[0]);
}
else
{
    foreach(var entry in model.GetVisitors())
        Console.WriteLine("{0, -20}{1, -6}{2, 16}", entry.Name, entry.Visits, entry.Recent);
}
