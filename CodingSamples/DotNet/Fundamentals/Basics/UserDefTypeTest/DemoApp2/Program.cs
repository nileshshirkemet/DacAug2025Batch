using System;

class Program
{
	static void Advise(ref Investment inv)
	{
		inv.AllowRisk(inv.TotalPayment() < 500000);
	}

	//a method can accept an uninitialized reference through a parameter
	//qualified with out keyword which it must initialize before it returns
	static bool TryPremiumScheme(double amount, out Investment inv)
	{
		if(amount < 100000)
		{
			inv = new Investment();
			return false;
		}
		inv = new Investment(amount, 5);
		if(amount < 250000)
			inv.AllowRisk(RiskLevel.High);
		else
			inv.AllowRisk(RiskLevel.Low);
		return true;
	}

	static void Main(string[] args)
	{
		Console.WriteLine("Welcome Investor!");
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		Investment myinv = new Investment(p, n);
		Console.WriteLine("Future value in no-risk investment  : {0:0.00}", myinv.FutureValue());
		myinv.AllowRisk(true);
		Console.WriteLine("Future value in low-risk investment : {0:0.00}", myinv.FutureValue());
		Advise(ref myinv); 
		Console.WriteLine("Future value in smart investment    : {0:0.00}", myinv.FutureValue());
		myinv.AllowRisk(RiskLevel.High);
		Console.WriteLine("Future value in high-risk investment: {0:0.00}", myinv.FutureValue());
		if(n == 5 && TryPremiumScheme(p, out Investment prinv))
		{
			Console.WriteLine("Future value in premium investment: {0:0.00}", prinv.FutureValue());
		}
	}
}

