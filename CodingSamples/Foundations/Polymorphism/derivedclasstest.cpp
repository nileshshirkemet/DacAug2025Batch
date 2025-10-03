#include "banners.h"
#include <cstdio>

double Purchase(const Banner& each, int copies)
{
    float rate = copies < 5 ? 0.85 : 0.80;
    //when a virtual member function is called on a reference/pointer
    //dynamic binding is used to dispatch the invocation
    return rate * copies * each.Area();
}

int main(void)
{
    float w, h;
    int n;
    printf("Dimensions of Banner: ");
    scanf("%f%f", &w, &h);
    printf("Number of Banners   : ");
    scanf("%d", &n);

    Banner a(w, h);
    printf("Total payment for regular banner: %.2lf\n", Purchase(a, n));

    CurvedBanner b(w, h, 1.5);
    printf("Total payment for curved banner: %.2lf\n", Purchase(b, n));

}
