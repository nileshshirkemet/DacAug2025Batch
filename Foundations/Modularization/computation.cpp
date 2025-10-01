#include <cmath>

double Compute(int first, int last, float level)
{
    double result = 0;

    for(int value = first; value <= last; ++value)
    {
        result += pow(value, level);
    }

    return result;
}
