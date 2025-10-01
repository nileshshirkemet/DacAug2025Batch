#include <cstdio>

double BannerPrice(float width, float height)
{
    float rate = width > height ? 0.85f : 0.95f;
    return width * height * rate;
}

int main(void)
{
    float w, h;
    int n;

    printf("Dimensions of Banner: ");
    scanf("%f%f", &w, &h);
    printf("Number of Banners   : ");
    scanf("%d", &n);

    printf("Payment for borderless banner = %.2lf\n", n * BannerPrice(w, h));
    printf("Payment for borderered banner = %.2lf\n", n * BannerPrice(w + 1, h + 1));
}