#include <cstdio>

int main(void)
{
    long num = 0;
    printf("Positive Integer: ");
    scanf("%ld", &num);

    long a = 1;
    int c = 0;

    do
    {
        a = a * 10;
        c = c + 1;
    }
    while(a <= num);

    printf("Number of Digits = %d\n", c);
}