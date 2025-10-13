using System.Xml.Serialization;

class Program
{
    //generic method with type-parameter T
    static T Select<T>(int index, T first, T second)
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

 

    static void Main(string[] args)
    {
        if(args.Length > 0 && int.TryParse(args[0], out int s))
        {
            string ss = Select(s, "June", "July");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(s, 7.25, 9.75);
            Console.WriteLine($"Selected double = {sd}");
            //Select(s, ss, sd);
        }
        else
        {

        }
    }
}