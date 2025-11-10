package app;

import static java.lang.foreign.ValueLayout.*;
import java.lang.foreign.Arena;
import java.lang.foreign.FunctionDescriptor;
import java.lang.foreign.Linker;
import java.lang.foreign.MemorySegment;
import java.lang.foreign.SymbolLookup;
import java.lang.invoke.MethodHandle;

public class Program {

    public static void main(String[] args) throws Throwable {
        long m = Long.parseUnsignedLong(args[0]);
        int n = Integer.parseInt(args[1]);
        SymbolLookup primesLibLookup = SymbolLookup.libraryLookup("native/libprimes.so", Arena.global());
        MethodHandle primesFetchHandle = Linker.nativeLinker().downcallHandle(
            primesLibLookup.findOrThrow("primes_fetch"), 
            FunctionDescriptor.ofVoid(JAVA_LONG, JAVA_INT, ADDRESS, ADDRESS)
        );
        try(Arena arena = Arena.ofConfined()){
            MemorySegment primes = arena.allocate(JAVA_LONG, n);
            if(n < 5){
                primesFetchHandle.invoke(m, n, primes, MemorySegment.NULL);
                System.out.println("All Primes");
            }
            for(int i = 0; i < n; ++i)
                System.out.println(primes.getAtIndex(JAVA_LONG, i));
        }

    }
}
