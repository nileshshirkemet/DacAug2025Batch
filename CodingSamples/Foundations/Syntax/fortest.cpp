#include <cstdio>

int main(void)
{
    long lower = 0, upper = 0, result = 0;

    printf("Lower and Upper Limit: ");
    scanf("%ld%ld", &lower, &upper);

    for(long value = lower; value <= upper; ++value)
    {
        result += value * value;
    }

    printf("Sum of Squares = %ld\n", result);
}
