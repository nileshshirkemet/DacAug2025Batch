        .include "common.i"

        .start

        GetInt  askl            #rax=M
        GetInt  asku, rdi       #rdi=N
        cmp     rax, rdi
        jg      1f
        sub     rax, 1
        mov     rbx, rax
        add     rbx, 1
        mul     rbx
        shr     rax, 1
        xchg    rax, rdi        #rax=N, rdi=S(M-1)
        mov     rbx, rax
        add     rbx, 1
        mul     rbx
        shr     rax, 1          #rax=S(N)
        sub     rax, rdi
        PutInt  tell
 1:     PutStr  done

        .stop

askl:   .string "Lower Limit: "
asku:   .string "Upper Limit: "
tell:   .string "Computation Result = "
done:   .string "Goodbye!\n"

        .end
