package payroll;

//a class defined with public keyword is visible
//to classes defined outside of its package
public class Employee {
    
    private int hours;
    private float rate;

    public Employee(int h, float r) {
        hours = h;
        rate = r;
    }

    //parameterless constructor
    public Employee() {
        this(0, 50);
    }

    //defining a logical Workdays property using get/set methods
    public int getWorkDays() {
        return hours / 8;
    }

    public void setWorkDays(int value) {
        hours = 8 * value;
    }

    public float getDailyWages() {
        return 8 * rate;
    }

    public void setDailyWages(float value) {
        rate = value / 8;
    }

    public double income() {
        double payment = hours * rate;
        int ot = hours - 180;
        if(ot > 0)
            payment += ot * 50;
        return payment;
    }
}
