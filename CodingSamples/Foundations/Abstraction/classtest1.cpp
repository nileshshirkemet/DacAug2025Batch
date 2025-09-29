#include "banner1.h"
#include <cstdio>

double Purchase(Banner each, int copies)
{
    float rate = copies < 5 ? 0.85 : 0.80;
    return rate * copies * each.Area(); //Banner::Area(&each)
}

int main(void)
{
    int n;
    printf("Number of banners: ");
    scanf("%d", &n);

    Banner a; //activation using default constructor 
    printf("Total payment for standard banner: %.2lf\n", Purchase(a, n));

    float w, h;
    printf("Dimensions of custom banner: ");
    scanf("%f%f", &w, &h);

    a.Resize(w, h); //Banner::Rezize(&a, w, h);
    a.Reshape(true);
    printf("Total payment for customized banner: %.2lf\n", Purchase(a, n));
    
}
