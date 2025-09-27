        .include "common.i"

        .global gcd             #gcd is visible to other linked modules
        .type   gcd, %function  #gcd refers to a procedure which fallows calling-conventions
gcd:
1:      cmp     rdi, rsi
        je      3f
        jg      2f
        sub     rsi, rdi
        jmp    	1b
2:      sub     rdi, rsi
        jmp     1b
3:      mov     rax, rdi        
        ret

        .end
