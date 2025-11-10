package app;

import java.lang.foreign.FunctionDescriptor;
import java.lang.foreign.Linker;
import java.lang.foreign.SymbolLookup;
import java.lang.foreign.ValueLayout;
import java.lang.invoke.MethodHandle;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) throws Throwable {
        //load native library with the specified canonical(platform-neutral) 
        //name from a directory indicated within java.library.path
        System.loadLibrary(args[0]); 
        //restricted method - can only be called from a module for which 
        //native access is enabled
        MethodHandle depr = Linker.nativeLinker().downcallHandle(
            SymbolLookup.loaderLookup().findOrThrow("depreciation"), 
            FunctionDescriptor.of(ValueLayout.JAVA_DOUBLE, ValueLayout.JAVA_INT, ValueLayout.JAVA_INT)
        );
        Scanner input = new Scanner(System.in);
        System.out.print("Original price: ");
        double p = input.nextDouble();
        System.out.print("Useful life   : ");
        int l = input.nextInt();
        input.close();
        for(int n = 1; n < l; ++n){
            double d = (double)depr.invoke(l, n);
            System.out.printf("%-4d%16.2f%n", n, p * (1 - d));
        }
    }
}
