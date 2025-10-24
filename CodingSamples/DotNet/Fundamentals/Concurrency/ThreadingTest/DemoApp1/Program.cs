namespace DemoApp;

class Program
{
    [ThreadStatic] //each thread gets its own copy of this static variable
    static string manager;

    static void HandleJob(int jno)
    {
        Console.WriteLine("Thread<{0}> has accepted Job<{1}> for {2}", Environment.CurrentManagedThreadId, jno, manager);
        Activity.Perform(jno);
        Console.WriteLine("Thread<{0}> has finished Job<{1}> for {2}", Environment.CurrentManagedThreadId, jno, manager);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;
        Thread child = new Thread(() => 
        {
            manager = "Jack";
            HandleJob(n);
        });
        //Main thread exits after Main method returns and all
        //non-background threads have exited
        child.IsBackground = n > 5; 
        child.Start();
        manager = "Jill";
        HandleJob(2); 
        Console.WriteLine("Goodbye from Main thread!");
    }
}
