namespace Finance;

public static class Loans
{
    public static double GetMonthlyInstallment(double loan, int years, float rate)
    {
        double i = rate / 1200;
        int m = 12 * years;
        return loan * i / (1 - Math.Pow(1 + i, -m));
    }
}
