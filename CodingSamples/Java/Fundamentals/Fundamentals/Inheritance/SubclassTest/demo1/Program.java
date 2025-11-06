//automatically qualify Employee to payroll.Employee at compile-time
import payroll.Employee;
import payroll.SalesPerson;


class Program {

    private static double tax(Employee emp) {
        double i = emp.income();
        return i > 10000 ? 0.15 * (i - 10000) : 0;
    }

    private static double bonus(Employee emp) {
        if(emp instanceof SalesPerson)
            return 0;
        return 0.12 * emp.income();
    }

    public static void main(String[] args) {
        Employee jack = new Employee();
        jack.setWorkDays(23);
        jack.setDailyWages(424);
        System.out.printf("Jack's Income is %.2f, Tax is %.2f and Bonus is %.2f%n", jack.income(), tax(jack), bonus(jack));
        SalesPerson jill = new SalesPerson(184, 53, 62000); 
        System.out.printf("Jill's Income is %.2f, Tax is %.2f and Bonus is %.2f%n", jill.income(), tax(jill), bonus(jill));
    }
}