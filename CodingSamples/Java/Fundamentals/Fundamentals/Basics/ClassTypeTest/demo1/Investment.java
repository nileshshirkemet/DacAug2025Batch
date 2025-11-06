class Investment {

    //instance fields
    private double installment;
    private int years;
    private boolean risk;

    //constructor
    public Investment(double amount, int period) {
        installment = amount;
        years = period;
        risk = false;
    }

    //instance method - must be called on object
    public void allowRisk(boolean yes) {
        risk = yes;
    }

    public double totalPayment() {
        return installment * years;
    }

    public double futureValue() {
        double i = risk ? 0.08 : 0.06;
        return (installment / i) * (Math.pow(1 + i, years) - 1);
    }
}

