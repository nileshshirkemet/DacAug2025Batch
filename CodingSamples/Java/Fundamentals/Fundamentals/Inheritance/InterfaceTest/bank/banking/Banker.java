package banking;

public class Banker {
    
    private static long nid = System.currentTimeMillis() % 1000000;

    public static Account openCurrentAccount() {
        //local var type is inferred from initializer
        var acc = new CurrentAccount(); 
        acc.id = ++nid + 10000000;
        return acc;
    }

    public static Account openSavingsAccount() {
        var acc = new SavingsAccount(); 
        acc.id = ++nid + 20000000;
        return acc;
    }

    //a class with only static members does not require instantiation
    private Banker() {}
}
