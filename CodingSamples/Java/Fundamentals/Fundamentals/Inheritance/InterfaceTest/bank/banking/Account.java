package banking;

//a class declared with abstract keyword cannot be instantiated
public abstract class Account {
    
    long id;
    protected double balance;

    public long id() {
        return id;
    }

    public double balance() {
        return balance;
    }

    //a method declared with abstract keyword must be
    //overridden in the sub-class which supports instantiation
    public abstract void deposit(double amount);

    public abstract void withdraw(double amount) throws InsufficientFundsException;

    //method declared with final keyword cannot be overridden in the sub-class 
    //JVM can use more efficient static binding to invoke such a method
    public final void transfer(double amount, Account that) throws InsufficientFundsException {
        if(this == that)
            throw new IllegalTransferException();
        this.withdraw(amount);
        that.deposit(amount);
    }
}
