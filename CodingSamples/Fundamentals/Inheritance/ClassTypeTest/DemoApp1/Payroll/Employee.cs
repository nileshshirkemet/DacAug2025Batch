namespace Payroll
{
    //user-defined reference type
    class Employee
    {
        private int hours;
        private float rate;

        //parameterized constructor
        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
        }

        //parameterless constructor which calls the parameterized constructor
        public Employee() : this(0, 50)
        {
        }

        //Property - is a member of a class that enables getting/setting 
        //a value associated with its instance using field-access syntax
        public int Workdays
        {
            get
            {
                return hours / 8;
            }
            set
            {
                hours = 8 * value;
            }
        }

        public float DailyWages
        {
            get { return 8 * rate; }
            set { rate = value / 8; }
        }

        //a method declared with virtual keyword is overridable
        //in the derived class
        public virtual double Income()
        {
            double payment = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                payment += 50 * ot;
            return payment;

        }
    }
}