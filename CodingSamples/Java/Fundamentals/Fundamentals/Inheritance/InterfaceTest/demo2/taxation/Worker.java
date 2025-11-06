package taxation;

public class Worker implements TaxPayer {

    private int jobs;

    public Worker(int jobs) {
        this.jobs = jobs;
    }

    public double annualIncome() {
        return 144000 + 300 * jobs;
    }
    
}
