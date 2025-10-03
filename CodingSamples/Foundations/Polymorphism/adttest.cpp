#include "boards.h"
#include <iostream>

double Purchase(const Ads::Signboard* each, int count)
{
    float discount = count < 10 ? 0 : 0.05;
    return count * (1 - discount) * each->Price();
}

int main(void)
{
    float d;
    int n;
    std::cout << "Size and Number of boards: ";
    std::cin >> d >> n;

    Ads::RectangularBoard first(0.8 * d, 0.6 * d, Ads::Substance::Wood);
    std::cout << "Total payment for wooden rectangular board: "
              << Purchase(&first, n)
              << std::endl;
    Ads::CircularBoard second(d, Ads::Substance::Metal);
    std::cout << "Total payment for metalic cicular board   : "
              << Purchase(&second, n)
              << std::endl;
}