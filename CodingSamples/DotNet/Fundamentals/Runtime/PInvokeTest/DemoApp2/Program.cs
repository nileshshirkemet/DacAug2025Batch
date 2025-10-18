using System.Runtime.InteropServices;

namespace DemoApp;

//see DemoApp.csproj to enable usage of unsafe keyword
unsafe class Program
{
    [DllImport("dijkstra", EntryPoint = "gcd")]
    extern static nint GreatestDivisor(nint first, nint second);

    [DllImport("native/libprimes.so", EntryPoint = "primes_fetch")]
    extern static void FetchPrimes(ulong start, int count, ulong* selected, delegate*<ulong, bool> selector);

    //Span<T> provides a common interface for accessing elements of type T
    //from a memory block on the stack on on the heap in a safe manner
    static void PrintPrimes(string title, Span<ulong> group)
    {
        Console.WriteLine(title);
        foreach(ulong prime in group)
            Console.WriteLine(prime);
    }

    static bool IsFavorite(ulong prime) => (prime - 1) % 4 == 0;

    static void Main(string[] args)
    {
        if(args[0] == "gcd")
        {
            nint m = nint.Parse(args[1]);
            nint n = nint.Parse(args[2]);
            Console.WriteLine("G.C.D = {0}", GreatestDivisor(m, n));
        }
        else if(args[0] == "primes")
        {
            ulong m = ulong.Parse(args[1]);
            int n = int.Parse(args[2]);
            if(n < 5)
            {
                ulong* primes = stackalloc ulong[n];
                FetchPrimes(m, n, &primes[0], null);
                PrintPrimes("All Primes", new Span<ulong>(primes, n));
            }
            else
            {
                ulong[] primes = new ulong[n];
                //a pointer that addresses a value enclosed within a reference
                //type data on the heap can only be initialized in a fixed statement
                //block to avoid relocation of this data during garbage collection
                //while the pointer is in scope
                fixed(ulong* first = &primes[0])
                {
                    FetchPrimes(m, n, first, &IsFavorite);
                }
                PrintPrimes("Favorite Primes", new Span<ulong>(primes));
            }
        }
    }
}
