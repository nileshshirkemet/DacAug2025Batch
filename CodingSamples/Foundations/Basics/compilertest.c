#include "common.h"

int main(void)
{
        long int m = GetInt("Lower Limit        : ");
        long int n = GetInt("Upper Limit        : ");
        if(m <= n)
        {
                long int result = n * (n + 1) / 2 - (m - 1) * m / 2;
                PutInt("Computation Result = ", result);
        }
        PutStr("Goodbye!\n");
}
