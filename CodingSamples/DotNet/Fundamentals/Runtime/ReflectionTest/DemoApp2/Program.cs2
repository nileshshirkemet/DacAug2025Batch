using System.Reflection;
using Finance;

double p = double.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
object policy = Activator.CreateInstance(t); //dynamic activation
MethodInfo scheme = t.GetMethod(args[2]);
int m = 10;
for(int n = 1; n <= m; ++n)
{
    float r = (float)scheme.Invoke(policy, [p, n]); //late binding
    double emi = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -6}{1, 16:0.00}", n, emi);
}
