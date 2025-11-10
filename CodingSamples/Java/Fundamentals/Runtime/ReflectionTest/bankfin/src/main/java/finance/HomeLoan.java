package finance;

public class HomeLoan {

    public float common(double amount, int period) {
        return amount < 5000000 ? 8.5f : 8;
    }

    public float women(double amount, int period) {
        return common(amount, period) - 1;
    }

    @MaxDuration(12) //value=12
    public float welfare(double amount, int period) {
        return 0.6f * common(amount, period);
    }


}
