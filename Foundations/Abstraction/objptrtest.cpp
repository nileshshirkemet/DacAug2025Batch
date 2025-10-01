#include "interval1.h"
#include <cstdio>

//const qualified pointer type parameter treats the
//addressed object as read-only and as such only
//const member functions of its class can be called
double Speed(float distance, const Interval* period)
{
    //period->Adjust(100);
    return distance / period->Time(); //period[0].Time()
}

int main(void)
{
    Interval a(1, 90); //activating interval on stack with parameterized constructor
    a.Print();
    printf("Speed for this Interval = %.2lf\n", Speed(600, &a));
    long t;
    printf("Time: ");
    scanf("%ld", &t);
    if(t >= 10)
    {
        Interval b; //activating interval on stack with default constructor
        b.Adjust(t);
        b.Print();
        printf("Speed for this Interval = %.2lf\n", Speed(600, &b));
    }//destructor of b is called here because b is going out of scope

    puts("--------------------------------------");
    printf("Number of Intervals activated = %d\n", Interval::Count());
}