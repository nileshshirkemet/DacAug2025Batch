using System;

class Program
{

	static void Main(string[] args)
	{
		System.Console.WriteLine("Welcome Investor!");
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		System.Console.WriteLine("Future value in riskless investment: {0:0.00}", Investment.FutureValue(p, n, false));
		System.Console.WriteLine("Future value in riskful investment : {0:0.00}", Investment.FutureValue(p, n, true));
	}
}

