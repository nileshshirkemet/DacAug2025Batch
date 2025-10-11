namespace Taxation;

interface ITaxPayer
{
    decimal AnnualIncome();

    //default interface method - is a virtual method defined with a specific
    //implementation in the interface, such implementation can only be called
    //on a reference of this interface type
    decimal IncomeTax()
    {
        decimal i = AnnualIncome() - 120000;
        return i > 0 ? 0.15m * i : 0;
    }
} 