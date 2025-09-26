#include <cstdio>

extern double Compute(int, int, float);

int main(void)
{
    int m, n;

    printf("Lower and Upper Limit: ");
    scanf("%d%d", &m, &n);

    printf("Result of basic computation    = %lf\n", Compute(m, n, 1));
    printf("Result of advanced computation = %lf\n", Compute(m, n, 2.5));
}