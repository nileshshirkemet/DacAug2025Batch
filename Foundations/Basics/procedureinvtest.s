        .include "common.i"


compute:        #procedure with argument in rax
        mov     rbx, rax
        add     rbx, 1
        mul     rbx
        shr     rax, 1
        mul     rax
        ret     #result in rax

        .start

        GetInt  askl            #rax=M
        GetInt  asku, rdi       #rdi=N
        cmp     rax, rdi
        jg      1f
        sub     rax, 1
        call    compute
        xchg    rax, rdi        #rax=N, rdi=S(M-1)
        call    compute
        sub     rax, rdi
        PutInt  tell
 1:     PutStr  done

        .stop

askl:   .string "Lower Limit: "
asku:   .string "Upper Limit: "
tell:   .string "Computation Result = "
done:   .string "Goodbye!\n"

        .end
