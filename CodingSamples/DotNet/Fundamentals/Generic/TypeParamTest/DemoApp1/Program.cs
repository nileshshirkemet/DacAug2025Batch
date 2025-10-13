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

    static T Select<T>(T first, T second) where T: IComparable<T>
    {
        if(first.CompareTo(second) > 0)
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
            Interval si = Select(s, new Interval(4, 40), new Interval(3, 40));
            Console.WriteLine($"Selected double = {si}");

        }
        else
        {
            string ss = Select("June", "July");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(7.25, 9.75);
            Console.WriteLine($"Selected double = {sd}");
            Interval si = Select(new Interval(4, 30), new Interval(3, 40));
            Console.WriteLine($"Selected double = {si}");
        }
    }
}