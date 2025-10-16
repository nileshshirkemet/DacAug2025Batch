namespace Finance;

public class HomeLoan
{
    public float Common(double amount, int period) => amount < 5000000 ? 8.5f : 8.0f;

    public float Woman(double amount, int period) => Common(amount, period) - 1;

    public float Welfare(double amount, int period) => 0.6f * Common(amount, period);
}
