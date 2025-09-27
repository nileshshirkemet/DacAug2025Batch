#include <cstdio>

double BannerPrice(float width, float height)
{
    float rate = width > height ? 0.85f : 0.95f;
    return width * height * rate;
}

//function overloading - defining multiple functions within the
//same scope with same name but different list of parameter types
double BannerPrice(float width, float height, short layers)
{
    if(layers == 1)
        return BannerPrice(width, height);
    return 1.35 * width * height * layers;
}

int main(void)
{
    float w, h;
    int n;

    printf("Dimensions of Banner: ");
    scanf("%f%f", &w, &h);
    printf("Number of Banners   : ");
    scanf("%d", &n);

    printf("Payment for regular banner = %.2lf\n", n * BannerPrice(w, h));
    printf("Payment for premium banner = %.2lf\n", n * BannerPrice(w, h, 3));
}