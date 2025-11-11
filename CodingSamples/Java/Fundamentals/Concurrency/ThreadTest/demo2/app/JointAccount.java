package app;

public class JointAccount {
    
    private int balance;

    public int balance() {
        return balance;
    }

    public boolean debit(int amount) {
        boolean success = false;
        //to execute synchronized block a thread must lock the monitor
        //associated with the target (this) object, and this monitor
        //is unlocked at the end of the synchronized block
        synchronized(this){
            if(balance >= amount){
                balance = Activity.perform(balance, amount, -1);
                success = true;
            }
        }
        return success;
    }

    public synchronized void credit(int amount) {
        balance = Activity.perform(balance, amount, +1);
        this.notify(); //notify this object's monitor
    }

    public boolean debitAfterCredit(int amount) throws InterruptedException{
        synchronized(this){
            //wait on this object's monitor until it is notified
            //by some other thread
            this.wait();  
            return debit(amount);
        }
    }
}
