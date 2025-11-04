package payroll;

//defining SalesPerson as a subclass of Employee
public class SalesPerson extends Employee {
    
    private double sales;

    public SalesPerson(int h, float r, double s) {
        super(h, r);
        sales = s;
    }

    public double getSales() {
        return sales;
    }

    public void setSales(double value) {
        sales = value;
    }

    //overriding method of superclass by defining a method with 
    //a matching declaration in the subclass
    public double income() {
        double payment = super.income();
        if(sales >= 25000)
            payment += 0.05 * sales;
        return payment;
    }
}

