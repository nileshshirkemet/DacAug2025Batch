class Investment {

    //a method defined with static keyword can be called on the class
    public static double futureValue(double installment, int years, boolean risk) {
        double i = risk ? 0.08 : 0.06;
        return (installment / i) * (Math.pow(1 + i, years) - 1);
    }
}
