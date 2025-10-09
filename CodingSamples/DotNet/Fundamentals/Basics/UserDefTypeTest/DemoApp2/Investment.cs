struct Investment
{
    private double installment;
    private int years;
    private RiskLevel risk;

    public Investment(double amount, int period)
    {
        installment = amount;
        years = period;
        risk = RiskLevel.None;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes ? RiskLevel.Low : RiskLevel.None;
    }

    //method overloading - defining a new method in a type with a name
    //matching with another method in that type but with different list
    //of parameter types 
    public void AllowRisk(RiskLevel level)
    {
        risk = level;
    }

    public double TotalPayment()
    {
        return installment * years;
    }

    public double FutureValue()
    {
        double i;
        switch(risk)
        {
            case RiskLevel.Low:
                i = 0.08;
                break;
            case RiskLevel.High:
                i = 0.11;
                break;
            default:
                i = 0.06;
                break;
        }
        return (installment / i) * (System.Math.Pow(1 + i, years) - 1);
    }
}
