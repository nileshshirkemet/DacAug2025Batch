m = int(input('Lower Limit        : '))
n = int(input('Upper Limit        : '))
if m <= n:
        result = n * (n + 1) / 2 - (m - 1) * m / 2
        print('Computation Result =', int(result))
print("Goodbye!")
