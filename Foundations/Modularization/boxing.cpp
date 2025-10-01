#include "boxing.h"

double BoxVolume(float l, float b, float h, float t)
{
    if(t >= l / 4 || t >= b / 4 || t >= h / 4)
    {
        //exit the function by throwing a value of float type,
        //this will branch into the catch block which receives
        //a float type value in the caller's code
        throw t;
    }
    return (l - 2 * t) * (b - 2 * t) * (h - 2 * t);
}