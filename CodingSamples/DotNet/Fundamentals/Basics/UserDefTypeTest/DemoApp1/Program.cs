using System;

class Program
{
	//a method can accept an initialized reference as argument
	//through a parameter declared with ref qualifier before its type 
	static void Advise(ref Investment inv)
	{
		//inv impliciltly indirects to the value whose reference is assigned to inv
		inv.AllowRisk(inv.TotalPayment() < 500000);
	}

	static void Main(string[] args)
	{
		Console.WriteLine("Welcome Investor!");
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		Investment myinv = new Investment(p, n);
		Console.WriteLine("Future value in no-risk investment : {0:0.00}", myinv.FutureValue());
		myinv.AllowRisk(true);
		Console.WriteLine("Future value in low-risk investment: {0:0.00}", myinv.FutureValue());
		Advise(ref myinv); //passing reference to myinv
		Console.WriteLine("Future value in smart investment   : {0:0.00}", myinv.FutureValue());
	}
}

