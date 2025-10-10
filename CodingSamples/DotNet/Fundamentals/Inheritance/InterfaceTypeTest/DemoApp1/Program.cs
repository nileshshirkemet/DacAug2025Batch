using Banking;

class Program
{
    static void Main(string[] args)
    {
        Banker.Greet();
        Account jack = Banker.OpenCurrentAccount();
        jack.Deposit(10000);
        Account jill = Banker.OpenSavingsAccount();
        jill.Deposit(15000);
        Account john = Banker.OpenSavingsAccount();
        john.Deposit(25000);
        Console.WriteLine("Jack's Account ID is {0} and Initial Balance is {1:0.00}", jack.Id, jack.Balance);
        Console.WriteLine("Jill's Account ID is {0} and Initial Balance is {1:0.00}", jill.Id, jill.Balance);
        Console.WriteLine("John's Account ID is {0} and Initial Balance is {1:0.00}", john.Id, john.Balance);
        if(args.Length > 0)
        {
            Console.WriteLine("Jill is making a payment of {0} to Jack...", args[0]);
            try
            {
                decimal payment = decimal.Parse(args[0]);
                jill.TransferFunds(payment, jack); //Banker.TransferFunds(jill, payment, jack);
                Console.WriteLine("Jill's payment succeeded.");
            }
            catch(InsufficientFundsException)
            {
                Console.WriteLine("Jill's payment failed due to lack of funds!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error - {0}", ex.Message);
            }
        }
        Console.WriteLine("Jack's final Balance is {0:0.00}", jack.Balance);
        Console.WriteLine("Jill's final Balance is {0:0.00}", jill.Balance);
        Console.WriteLine("John's final Balance is {0:0.00}", john.Balance);

    }
}
