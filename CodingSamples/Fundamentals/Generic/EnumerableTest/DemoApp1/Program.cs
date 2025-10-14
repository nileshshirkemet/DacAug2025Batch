using Common;

SimpleStack<string> a = new SimpleStack<string>();
a.Push("Monday");
a.Push("Tuesday");
a.Push("Wednesday");
a.Push("Thursday");
a.Push("Friday");
for(var e = a.GetEnumerator(); e.MoveNext();)
{
    Console.WriteLine(e.Current);
}
Console.WriteLine("-------------------------");
a[2] = "Holiday"; //using indexer
while(a.Length > 0)
{
    Console.WriteLine(a.Pop());
}
Console.WriteLine("-------------------------");
SimpleStack<double> b = new SimpleStack<double>();
b.Push(4.31);
b.Push(7.42);
b.Push(6.53);
b.Push(3.24);
foreach(double d in b)
    Console.WriteLine(d);
Console.WriteLine("-------------------------");
foreach(Interval i in Generator.GenerateIntervals(3))
    Console.WriteLine(i);