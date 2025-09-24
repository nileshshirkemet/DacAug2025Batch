        .include "common.i"

        .extern gcd

        .start

        GetInt  askn, rdi
        GetInt  askn, rsi
        call    gcd
        PutInt  tell
        
        .stop

askn:   .string "Positive Integer : "
tell:   .string "Greatest Divisor = "

        .end

