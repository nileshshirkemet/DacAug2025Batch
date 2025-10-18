using System.Runtime.InteropServices;

namespace BankInvLib;

public class Annuity
{
    public double Installment { get; init; }

    public int Years { get; init; }

    public double FutureValue()
    {
        double i = Years < 5 ? 0.06 : 0.07;
        return (Installment / i) * (Math.Pow(1 + i, Years) - 1);
    }

    [UnmanagedCallersOnly(EntryPoint = "annuity_future_value")]
    public static double GetFutureValue(double payment, int count)
    {
        var a = new Annuity 
        {
            Installment = payment,
            Years = count
        };
        return a.FutureValue();
    }
}

