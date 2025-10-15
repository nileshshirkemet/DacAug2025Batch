class Program
{
    static double SafeScheme(int period)
    {
        return period < 3 ? 6 : 7;
    }

    static void Main(string[] args)
    {
        Investment myinv = new Investment
        {
            Installment = double.Parse(args[0]),
            Years = int.Parse(args[1])
        };
        Console.WriteLine("Future value in safe investment : {0:0.00}", myinv.FutureValue(SafeScheme));     
        double bi = 8.75;
        //passing lambda-expression which captures (by reference) variable bi
        Console.WriteLine("Future value in risky investment: {0:0.00}", myinv.FutureValue(n => bi + 0.25 * n));     
    }
}
