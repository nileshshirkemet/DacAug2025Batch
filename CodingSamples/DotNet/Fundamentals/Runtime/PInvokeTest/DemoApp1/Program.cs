using System.Runtime.InteropServices;

namespace DemoApp;

class Program
{
    delegate double DepreciationInvoker(int life, int after);

    static void Main(string[] args)
    {
        Console.Write("Original price: ");
        double p = double.Parse(Console.ReadLine());
        Console.Write("Useful life   : ");
        int l = int.Parse(Console.ReadLine());
        nint libptr = NativeLibrary.Load(args[0]);
        nint fcnptr = NativeLibrary.GetExport(libptr, "depreciation");
        DepreciationInvoker depr = Marshal.GetDelegateForFunctionPointer<DepreciationInvoker>(fcnptr);
        for(int n = 1; n < l; ++n)
        {
            double d = depr.Invoke(l, n);
            Console.WriteLine("{0, -4}{1, 16:0.00}", n, p * (1 - d));
        }
        NativeLibrary.Free(libptr);
    }
}
