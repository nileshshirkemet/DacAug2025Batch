namespace Banking;

class SavingsAccount : Account
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
}