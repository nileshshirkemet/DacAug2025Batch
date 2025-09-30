#include "interval1.h"
#include <cstdio>

//reference type(T&) - is a syntactically simpler and safer
//alternative to a pointer type(T*) in function declarations,
//a reference is automatically initialized with the address of
//the variable in its required initializer and always automatically
//indirects to value of that varaible and as such it does not
//support reinitialization or multiple indirection
double Speed(float distance, const Interval& period)
{
    //period.Adjust(100);
    return distance / period.Time(); 
}

int main(void)
{
    Interval a(1, 90); 
    a.Print();
    printf("Speed for this Interval = %.2lf\n", Speed(600, a));
    long t;
    printf("Time: ");
    scanf("%ld", &t);
    if(t >= 10)
    {
        Interval b; 
        b.Adjust(t);
        b.Print();
        printf("Speed for this Interval = %.2lf\n", Speed(600, b));
    }

    puts("--------------------------------------");
    printf("Number of Intervals activated = %d\n", Interval::Count());
}