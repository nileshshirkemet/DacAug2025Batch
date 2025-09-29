#include "interval1.h"
#include <cstdio>

int main(void)
{
    Interval a(1, 90); //activating interval on stack with parameterized constructor
    a.Print();
    Interval b; //activating interval on stack with default constructor
    b.Adjust(200);
    b.Print();
    printf("Number of Intervals activated = %d\n", Interval::Count());
}