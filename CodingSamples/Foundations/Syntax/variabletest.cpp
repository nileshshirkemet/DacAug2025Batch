#include <cstdio>

//global variable - visible to all statement blocks
//const qualifier makes the variable read-only
const double rate = 0.85; 

int main(void)
{
    //local variable - only visible in current statement block
    float width = 0, height = 0; 
    short int count = 0;
    printf("Dimensions of Banner: ");
    scanf("%f%f", &width, &height);
    printf("Number of Banners   : ");
    scanf("%hd", &count);

    double payment = count * width * height * rate;

    printf("Total Payment: %.2lf\n", payment);
}
