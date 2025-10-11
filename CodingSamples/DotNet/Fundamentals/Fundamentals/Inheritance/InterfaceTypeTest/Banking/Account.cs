namespace Banking;

//a class declared with abstract keyword does not support activation
public abstract class Account
{
    public long Id { get; internal set; }

    public decimal Balance { get; protected set; }

    //an instance method declared with abstract keyword
    //is pure virtual, it must be overridden by non-abstract
    //classes derived from this class, such a method cannot
    //be defined in a non-abstract type
    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}