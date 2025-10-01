        .include "common.i"

        .extern gcd

        .start

        GetInt  askn, rdi
        GetInt  askn, rsi
        call    lcm
        PutInt  tell

        .stop

lcm:
        sub     rsp, 16         #make space on stack frame for two temp values 
        mov     [rsp], rdi
        mov     [rsp+8], rsi
        call    gcd
        mov     rcx, rax        #rcx=gcd(first, second)
        mov     rax, [rsp]
        mov     rsi, [rsp+8]
        mul     rsi             #rax=first/second
        div     rcx
        add     rsp, 16         #unwinding stack frame
        ret

askn:   .string "Positive Integer : "
tell:   .string "Least Multiple   = "

        .end

