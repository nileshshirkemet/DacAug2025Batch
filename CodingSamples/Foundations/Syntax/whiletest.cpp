#include <cstdio>

int main(void)
{
    long num = 0;
    printf("Positive Integer: ");
    scanf("%ld", &num);

    long sum = 0;

    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }

    printf("Sum of Digits = %ld\n", sum);    
}