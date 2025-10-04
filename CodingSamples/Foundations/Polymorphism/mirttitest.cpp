#include "boards.h"
#include <iostream>

using namespace Ads;

//Runtime Type Identification (RTTI) - is a mechanism for determining
//if the type of an instance is compatible with another type at runtime,
//it is supported by including type-information of a class within the
//v-table of that class
double Purchase(const Signboard* each, int count)
{
    float discount = count < 10 ? 0 : 0.05;
    double payment = count * (1 - discount) * each->Price();
    //the expression dynamic_cast<T*>(ptr) uses RTTI to check whether
    //the type of instance pointed by ptr is compatible with type T 
    //and if so it yields a pointer that addresses T type section of
    //that instance otherwise it yields null(zero) pointer 
    const Wasteful* w = dynamic_cast<const Wasteful*>(each);
    if(w)
        payment += count * w->Loss();
    return payment;
}

int main(void)
{

    float d;
    int n;
    std::cout << "Size and Number of boards: ";
    std::cin >> d >> n;

    RectangularBoard first(0.8 * d, 0.6 * d, Substance::Wood);
    std::cout << "Total payment for wooden rectangular board: "
              << Purchase(&first, n)
              << std::endl;
    CircularBoard second(d, Substance::Metal);
    std::cout << "Total payment for metalic cicular board   : "
              << Purchase(&second, n)
              << std::endl;
}
