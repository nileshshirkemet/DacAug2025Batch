import sys
from ctypes import *

lib = CDLL('./bin/Release/net9.0/linux-x64/publish/libBankInv.so')
lib.annuity_future_value.argtypes = [c_double, c_int]
lib.annuity_future_value.restype = c_double
m = float(sys.argv[1])
n = int(sys.argv[2])
print('Future Value = %.2f' % lib.annuity_future_value(m, n))
