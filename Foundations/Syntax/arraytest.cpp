#include <cstdio>

//array with 5 elements indexed from 0 to 4
const double rate[] = {0.85, 0.95, 1.25, 1.75, 2.65}; 

int main(void)
{
    float width = 0, height = 0; 
    short int count = 0;
    int m = 0;
    printf("Dimensions of Banner: ");
    scanf("%f%f", &width, &height);
    printf("Number of Banners   : ");
    scanf("%hd", &count);
    printf("Material Type[1-5]  : ");
    scanf("%d", &m);

    double payment = count * width * height * rate[m - 1]; //indexing array

    printf("Total Payment: %.2lf\n", payment);
}
