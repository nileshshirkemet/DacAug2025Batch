namespace Payroll
{
    //SalesPerson is a derived class of Employee(base class)
    class SalesPerson : Employee
    {
        //automatic property
        public double Sales { get; set; }

        //derived class constructor must call base class constructor
        //otherwise parameterless constructor of base class is called
        //implicitly
        public SalesPerson(int h, float r, double s) : base(h, r)
        {
            Sales = s;
        }

        //method overriding - is defining a method (with override keyword)
        //in derived class whose declaration matches with the declaration
        //of a virtual method in the base class
        public override double Income()
        {
            double payment = base.Income();
            if(Sales >= 25000)
                payment += 0.05 * Sales;
            return payment;
        }
    }
}