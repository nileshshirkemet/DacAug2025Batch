using System.Diagnostics;

namespace DemoApp;

class Program
{
    class Computation
    {
        private Stopwatch clock = new(); //new Stopwatch();

        public long Compute(int first, int count)
        {
            clock.Start();
            return Enumerable.Range(first, count)
                .AsParallel()
                .Select(Activity.Perform)
                .Sum();
        }

        public Task<long> ComputeAsync(int first, int count)
        {
            //Task<T>.Run(expression) starts and returns a new Task<T>
            //initialized with the specified expression
            return Task<long>.Run(() => Compute(first, count));
        }

        public double Time()
        {
            clock.Stop();
            return clock.Elapsed.TotalSeconds;
        }
    }

    //a method defined with async keyword can yield a Task
    //specified in return type using await statement
    static async Task HandleJob(int jno)
    {
        Console.Write("Computing...");
        var c = new Computation();
        //the await operator yields a task that includes its target task
        //continued with another task which executes the statements after
        //its usage
        long r = await c.ComputeAsync(1, jno);
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, c.Time());
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 5;
        var job = HandleJob(n);
        while(!job.IsCompleted)
        {
            Console.Write('.');
            Thread.Sleep(500); //pause current thread for 500 milliseconds
        }
    }
}
