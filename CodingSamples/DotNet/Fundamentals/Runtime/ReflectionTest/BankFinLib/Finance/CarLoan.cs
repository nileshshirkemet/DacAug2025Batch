namespace Finance;

public class CarLoan : PersonalLoan
{
    public override float Common(double amount, int period)
    {
        float rate = amount < 1000000 ? 11 : 12;
        if(period >= 6)
            rate += 1;
        return rate;
    }
}