namespace DemoApp;

class JointAccount
{
    public int Balance { get; private set; }

    public bool Debit(int amount)
    {
        bool success = false;
        Monitor.Enter(this); //lock monitor attached to 'this' object
        try
        {
            if(Balance >= amount)
            {
                Balance = Activity.Perform(Balance, amount, -1);
                success = true;
            }
        }
        finally
        {
            Monitor.Exit(this); //unlock monitor attached to'this' object
        }
        return success;
    }

    public void Credit(int amount)
    {
        lock(this)
        {
            Balance = Activity.Perform(Balance, amount, 1);
            //signal the monitor attached to this object
            Monitor.Pulse(this);
        }
    }

    public bool DebitAfterCredit(int amount)
    {
        lock(this)
        {
            //unlock monitor attached to this object and wait for
            //the monitor to be signalled by another thread
            Monitor.Wait(this);
            return Debit(amount);
        }
    }
}