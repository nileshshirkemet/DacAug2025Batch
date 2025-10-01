#include "boxing.h"
#include <cstdio>

int main(void)
{
    float l = 0, b = 0, h = 0, t = 0;

    printf("Dimensions of Box: ");
    scanf("%f%f%f", &l, &b, &h);
    printf("Thickness: ");
    scanf("%f", &t);

    try
    {
        double vol = (t == 0) ? BoxVolume(l, b, h) : BoxVolume(l, b, h, t);
        printf("Inner volume of box = %.1lf\n", vol);
    }
    catch(float e)
    {
        printf("Invalid thickness: %.1f\n", e);       
    }

    puts("Goodbye!");
}