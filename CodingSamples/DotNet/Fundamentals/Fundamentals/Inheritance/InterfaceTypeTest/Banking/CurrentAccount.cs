namespace Banking;

//a class declared with sealed keyword cannot be used as a base class
sealed class CurrentAccount : Account
{
    public override void Deposit(decimal amount)
    {
        if(Balance < 0)
            amount -= 500;
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
}
