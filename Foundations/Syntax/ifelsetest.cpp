#include <cstdio>


int main(void)
{
    float width = 0, height = 0; 
    short int count = 0;
    printf("Dimensions of Banner: ");
    scanf("%f%f", &width, &height);
    printf("Number of Banners   : ");
    scanf("%hd", &count);

    if(width > height)
    {
        double payment = count * width * height * 0.85;
        printf("Total Payment for Landscape Banner: %.2lf\n", payment);
    }
    else
    {
        double payment = count * width * height * 0.95;
        printf("Total Payment for Potrait Banner: %.2lf\n", payment);
    }
    
    puts("Goodbye!");
}
