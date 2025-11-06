import java.util.Date;

import taxation.TaxPayer;

class Auditor implements AutoCloseable {

    public Auditor() {
        System.out.printf("Auditor Log [%s] - starting audit session.%n", new Date());
    }

    public void audit(String id, TaxPayer employee) {
        System.out.printf("Auditing %s...%n", id);
        if(id.length() < 4)
            throw new IllegalArgumentException("Invalid ID");
        double payment = employee.incomeTax() + 500;
        System.out.printf("Total tax payment: %.2f%n", payment);
    }

    public void close() {
        System.out.printf("Auditor Log [%s] - ending audit session.%n", new Date());
    }
}
