#include "interval2.h"
#include <cstdio>

int main(void)
{
    Interval a(4, 50);
    a.Print();

    puts("Copying...");
    Interval b = a; //b(a);
    b.Print();

    Interval c(5, 15);
    c.Print();

    puts("Adding...");
    Interval d = b + c;
    d.Print();

    printf("Number of Intervals activated = %d\n", Interval::Count());
}
