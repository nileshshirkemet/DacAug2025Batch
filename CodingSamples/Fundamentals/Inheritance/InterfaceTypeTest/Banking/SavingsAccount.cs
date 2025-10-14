namespace Banking;

//multiple inheritance (of behavior)
class SavingsAccount : Account, IProfitable
{
    //a const identifier is replaced by its assigned value wherever it is used
    const decimal MinBal = 5000;

    public SavingsAccount()
    {
        Balance = MinBal;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    //a method declared with sealed keyword cannot be further 
    //overridden in the derived class
    public sealed override void Withdraw(decimal amount)
    {
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }

    public decimal AddInterest(int months)
    {
        decimal rate = Balance < 5 * MinBal ? 3 : 4;
        decimal interest = Balance * rate * months / 1200;
        Balance += interest;
        return interest;
    }

}