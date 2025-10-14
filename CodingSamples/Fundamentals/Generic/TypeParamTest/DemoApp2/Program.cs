using Common;

class Program
{
    static void PrintStack(IStackReader<object> store)
    {
        while(store.Length > 0)
            Console.WriteLine(store.Pop());
    }

    static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>();
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        PrintStack(a);
        Console.WriteLine("-------------------------");
        SimpleStack<Interval> b = new SimpleStack<Interval>();
        b.Push(new Interval(4, 31));
        b.Push(new Interval(7, 42));
        b.Push(new Interval(6, 53));
        b.Push(new Interval(3, 24));
        PrintStack(b);
    }
}