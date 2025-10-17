namespace Finance;

public class PersonalLoan
{
    [MaxDuration(6)]
    public virtual float Common(double amount, int period) => 10.5f + 0.5f * (period / 3);

    public float Employee(double amount, int period) => Common(amount, period) / 2; 
}
