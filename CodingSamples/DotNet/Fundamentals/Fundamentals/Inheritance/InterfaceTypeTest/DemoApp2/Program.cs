using Taxation;

class Program
{
    static void DoAuditing(string name, int count)
    {
        //a local variable whose type implements System.IDisposable can
        //be declared with using statement/qualifier so that Dispose() 
        //method is automatically called on this variable as soon as it 
        //goes out of scope
        using(var a = new Auditor())
        {
            if(count <= 10)
                a.Audit(name, new Supervisor(count));
            else
                a.Audit(name, new Worker(count));
        }
    }


    static void Main(string[] args)
    {
        try
        {
            string m = args[0].ToUpper();
            int n = int.Parse(args[1]);
            DoAuditing(m, n);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
