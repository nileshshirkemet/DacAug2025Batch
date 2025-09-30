#include "interval1.h"
#include <cstdio>

int main(void)
{
    int n(0);
    printf("Number of Intervals: ");
    scanf("%d", &n);

    if(n == 1)
    {
        //explicitly allocating memory for new instance on the runtime heap 
        //and initializing this instance using the specified constructor
        Interval* a = new Interval(3, 45); 
        a->Print();
        //calling destructor of the addressed instance on the runtime heap 
        //and deallocating the memory allocated to it
        delete a;
    }
    else
    {
        //explicitly allocating memory for an array of instances on tne runtime
        //heap and initializing these instances using default constructor
        Interval* a = new Interval[n];
        for(int i = 0; i < n; ++i)
        {
            a[i].Adjust(40 * i + 225);
            a[i].Print();
        }
        //calling destructor on each instance in an array on runtime heap
        //and deallocating memory allocated to this array
        delete[] a;
    }
}