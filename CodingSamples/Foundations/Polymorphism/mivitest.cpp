#include "boards.h"
#include <iostream>

using namespace Ads;

//struct is like class but whose members are public by default
struct FancyBoard : public RectangularBoard, public CircularBoard
{
    FancyBoard(float l, float b) : RectangularBoard(l, b, Substance::Plastic), CircularBoard(b, Substance::Plastic)
    {
    }

    double Area() const
    {
        return RectangularBoard::Area() + CircularBoard::Area();
    }

};

double Purchase(const Signboard& each, int count)
{
    float discount = count < 10 ? 0 : 0.05;
    return count * (1 - discount) * each.Price();
}

int main(void)
{
    float d;
    int n;
    std::cout << "Size and Number of boards: ";
    std::cin >> d >> n;

    RectangularBoard first(0.8 * d, 0.6 * d, Substance::Wood);
    std::cout << "Total payment for wooden rectangular board: "
              << Purchase(first, n)
              << std::endl;
    CircularBoard second(d, Substance::Metal);
    std::cout << "Total payment for metallic circular board : "
              << Purchase(second, n)
              << std::endl;
    FancyBoard third(0.8 * d, 0.6 * d);
    std::cout << "Total payment for plastic fancy board     : "
              << Purchase(third, n)
              << std::endl;
}
