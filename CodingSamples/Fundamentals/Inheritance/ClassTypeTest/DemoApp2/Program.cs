//C# supports top-level statements in one source file within a project
//with OutputType=Exe, these statements are copied by the compiler into
//the Main method of an auto-generated Program class

Console.WriteLine("Hello User!");
Interval a = new Interval(6, 50);
Interval b = new Interval(4, 15);
Print("Interval a", a);
Print("Interval b", b);
Interval c = new Interval(5, 110);
Interval d = b;
Print("Interval c", c);
Print("Interval d", d);
Print("Sum of a and b", a + b);
Console.WriteLine("-----------------------------");
Console.WriteLine("a is identical to b: {0}", ReferenceEquals(a, b));
Console.WriteLine("a is identical to c: {0}", ReferenceEquals(a, c));
Console.WriteLine("d is identical to b: {0}", ReferenceEquals(d, b));
Console.WriteLine("-----------------------------");
Console.WriteLine("a is equal to b: {0}", a.GetHashCode() == b.GetHashCode() && a.Equals(b));
Console.WriteLine("a is equal to c: {0}", Equals(a, c));
Console.WriteLine("d is equal to b: {0}", Equals(d, b));
//a local function (will be copied into Main method), such functions 
//cannot be overloaded
void Print(string name, object info)
{
    Console.WriteLine("{0} = {1}", name, info.ToString());
}


