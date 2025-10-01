#include <cstdio>

double Expense(int year)
{
    return 5 * year - 1;
}

double Income(int year)
{
    return (year * year + 1);
}

double CommonSum(int years, double (*sequence)(int))
{
    double total = 0;

    for(int y = 1; y <= years; ++y)
    {
        total += sequence(y);
    }

    return total;
}

int main(void)
{
    int count;
    printf("Number of years: ");
    scanf("%d", &count);

    printf("Total Expense = %.2f\n", CommonSum(count, &Expense));
    printf("Total Income  = %.2f\n", CommonSum(count, &Income));
}
