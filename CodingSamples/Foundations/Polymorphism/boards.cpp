#include "boards.h"
#define PI 3.14


double Ads::Signboard::Price() const
{
    return 1.25 * material * Area();
}

Ads::RectangularBoard::RectangularBoard(float width, float height, Ads::Substance medium)
{
    material = medium;
    if(width > height)
    {
        length = width;
        breadth = height;
    }
    else
    {
        length = height;
        breadth = width;
    }
}

double Ads::RectangularBoard::Area() const
{
    return length * breadth;
}

Ads::CircularBoard::CircularBoard(float diameter, Ads::Substance medium)
{
    material = medium;
    radius = diameter / 2;
    scrap = 0.4;
}

double Ads::CircularBoard::Area() const
{
    return PI * radius * radius;
}

double Ads::CircularBoard::Loss() const
{
    return (1 - scrap) * material * (4 - PI) * radius * radius;
}