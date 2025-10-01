#include <cstdio>

double Average(double first, double second, double* dev)
{
    dev[0] = first > second ? (first - second) / 2 : (second - first) / 2;
    return (first + second) / 2;
}

void Swap(double* first, double* second)
{
    double third = *first;
    *first = *second;
    *second = third;
}

int main(void)
{
    double x = 0, y = 0, d = 0;
    printf("Two Values: ");
    scanf("%lf%lf", &x, &y);

    printf("Original values: x = %lf, y = %lf\n", x, y);
    double a = Average(x, y, &d);
    printf("Average = %lf with Deviation = %lf\n", a, d);
    Swap(&x, &y);
    printf("Swapped values : x = %lf, y = %lf\n", x, y);
}
