class Investment {

    private double installment;
    private int years;

    public Investment(double installment, int years) {
        this.installment = installment;
        this.years = years;
    }

    public double futureValue(InterestRate rate) {
        double i = rate.forPeriod(years) / 100;
        return (installment / i) * (Math.pow(1 + i, years) - 1);
    }
}

