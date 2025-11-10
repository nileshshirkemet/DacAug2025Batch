package finance;

public class CarLoan extends PersonalLoan {
    
    @Override //source annotation
    public float common(double amount, int period) {
        float rate = amount < 1000000 ? 10 : 11;
        if(period > 4)
            rate += 0.5f;
        return rate;
    }
}
