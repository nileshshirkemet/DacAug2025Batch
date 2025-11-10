#pragma once

typedef unsigned long long pnum_t;

#ifdef __cplusplus
extern "C" {
#endif

void primes_fetch(pnum_t start, int count, pnum_t* selected, int (*selector)(pnum_t));

#ifdef __cplusplus
}
#endif

