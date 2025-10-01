        .include "common.i"

        .start

        GetInt  askm, rdi               #rdi=month
        mov     rcx, count              #direct addressing - rcx=3
        lea     rsi, count              #rsi = address linked to count
        mov     rax, [rsi+8*rdi]        #indirect addressing - rax=number of days
        mov     rbx, rax
        add     rbx, 1                  #immediate addessing 
        mul     rbx
        shr     rax, 1
	mul     rcx
        PutInt  tell
        
        .stop

askm:   .string "Month[1-12]      : "
tell:   .string "Collected Amount = "
count:	.quad	3, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31

        .end
