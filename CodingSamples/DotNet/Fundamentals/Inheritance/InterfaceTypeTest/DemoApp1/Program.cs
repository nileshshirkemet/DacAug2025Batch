using Banking;

class Program
{
    //a method can accept variable number of arguments of a given type
    //through its last array type parameter declared with params keyword
    static void PayAnnualInterest(params Account[] accounts)
    {
        foreach(Account acc in accounts)
        {
            //using 'as' operator for explicit type conversion, this operator yields 
            //null if the type of source is not compatible with the target type
            IProfitable p = acc as IProfitable;
            p?.AddInterest(12); //if(p != null) p.AddInterest(12);
        }
    }

    static void Main(string[] args)
    {
        Banker.Greet();
        Account jill = Banker.OpenSavingsAccount();
        jill.Deposit(15000);
        Account jack = Banker.OpenCurrentAccount();
        jack.Deposit(30000);
        Account john = Banker.OpenSavingsAccount();
        john.Deposit(35000);
        Console.WriteLine("Jill's Account ID is {0} and Initial Balance is {1:0.00}", jill.Id, jill.Balance);
        Console.WriteLine("Jack's Account ID is {0} and Initial Balance is {1:0.00}", jack.Id, jack.Balance);
        Console.WriteLine("John's Account ID is {0} and Initial Balance is {1:0.00}", john.Id, john.Balance);
        if(args.Length > 0)
        {
            try
            {
                decimal payment = decimal.Parse(args[0]);
            	Console.WriteLine("Jill is making a payment of {0} to Jack...", payment);
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
        else
        {
            Console.WriteLine("Paying annual interest...");
            PayAnnualInterest(jill, jack, john);
        }
        Console.WriteLine("Jill's final Balance is {0:0.00}", jill.Balance);
        Console.WriteLine("Jack's final Balance is {0:0.00}", jack.Balance);
        Console.WriteLine("John's final Balance is {0:0.00}", john.Balance);

    }
}
