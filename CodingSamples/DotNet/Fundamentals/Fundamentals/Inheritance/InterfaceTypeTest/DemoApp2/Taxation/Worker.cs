namespace Taxation;

struct Worker(int jobs) : ITaxPayer
{
    //explicit interface implementation - enables a type to provide a
    //private implementation for a method it inherits from an interface
    //using interface qualified name of that method, such implementation
    //can only be called on a reference of that interface type
    decimal ITaxPayer.AnnualIncome()
    {
        return 144000 + 400 * jobs;
    }
}