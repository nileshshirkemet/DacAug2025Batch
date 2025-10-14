namespace Taxation;

struct Supervisor(int subordinates) : ITaxPayer
{
    decimal ITaxPayer.AnnualIncome()
    {
        return 480000 + 3000 * subordinates;
    }
}
