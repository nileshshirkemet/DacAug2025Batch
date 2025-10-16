using DemoApp;

class Program
{
    static void PresentRecord(object info)
    {
        Type t = info.GetType();
        Console.WriteLine("<{0}>", t.Name);
        foreach(var p in t.GetProperties())
        {
            Console.WriteLine("  <{0}>{1}</{0}>", p.Name, p.GetValue(info));
        }
        Console.WriteLine("</{0}>", t.Name);
        Console.WriteLine();
    }


    static void Main()
    {
        Item i = Shop.GetPopularItem();
        PresentRecord(i);
        Customer c = Shop.GetBestCustomer();
        PresentRecord(c);
    }
}
