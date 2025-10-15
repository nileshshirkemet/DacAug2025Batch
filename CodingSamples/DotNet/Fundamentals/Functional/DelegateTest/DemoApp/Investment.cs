delegate double InterestRate(int period);

class Investment
{
    //a read-only property which can only be set in instance initializer
    public double Installment { get; init; } = 50000;

    //a property defined with required keyword must be set in instance initializer
    public required int Years { get; init; }

    public double FutureValue(InterestRate scheme)
    {
        double i = scheme.Invoke(Years) / 100;
        return (Installment / i) * (Math.Pow(1 + i, Years) - 1);
    }
}