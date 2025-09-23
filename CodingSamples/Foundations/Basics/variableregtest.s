        .include "common.i"

        .start
        
        GetInt  asku            #rax=N
        mov     rbx, rax        #rbx=N
        add     rbx, 1          #rbx=N+1
        mul     rbx             #rax=N*(N+1)
        shr     rax, 1          #rax=N*(N+1)/2
        PutInt  tell

        .stop

asku:   .string "Upper Limit        : "
tell:   .string "Computation Result = "

        .end
