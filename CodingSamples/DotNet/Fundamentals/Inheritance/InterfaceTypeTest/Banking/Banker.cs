namespace Banking;

//a class defined with static keyword can only define static members,
//such a class does not contain an instance constructor
public static class Banker
{
    private static long seed = DateTime.Now.Ticks % 1000000;

    public static void Greet()
    {
        Console.WriteLine("Welcome to MET Bank!");
    }

    public static Account OpenCurrentAccount()
    {
        //implicitly typed local - var is replaced from the type in the initializer
        var acc = new CurrentAccount();
        acc.Id = ++seed + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        //implicitly typed local - var is replaced from the type in the initializer
        var acc = new SavingsAccount();
        acc.Id = ++seed + 200000000;
        return acc;
    }

    //extension method - is a member of a static class whose first parameter
    //is declared with 'this' keyword, such a method can be called as an
    //instance method of its first argument type by importing the namespace
    //of its class
    public static bool TransferFunds(this Account source, decimal amount, Account target)
    {
        if(ReferenceEquals(source, target))
            return false;
        source.Withdraw(amount);
        target.Deposit(amount);
        return true;
    }
}