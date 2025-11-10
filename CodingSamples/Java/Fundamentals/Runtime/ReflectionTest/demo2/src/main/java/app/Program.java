package app;

import java.lang.invoke.MethodHandle;
import java.lang.invoke.MethodHandles;
import java.lang.reflect.Method;

import finance.Loans;
import finance.MaxDuration;

public class Program {
    
    public static void main(String[] args) throws Throwable {
        double p = Double.parseDouble(args[0]);
        Class<?> c = Class.forName("finance." + args[1]);
        Object policy = c.getConstructor().newInstance();
        Method scheme = c.getMethod(args[2], double.class, int.class);
        //a method-handle refers to a (checked) typed direct reference
        //to a method for its bound object
        MethodHandle schemeHandle = MethodHandles.lookup()
            .unreflect(scheme)
            .bindTo(policy);
        MaxDuration md = scheme.getAnnotation(MaxDuration.class);
        int m = md != null ? md.value() : 10;
        for(int n = 1; n <= m; ++n){
            //call referenced method with arguments
            float r = (float) schemeHandle.invoke(p, n);
            double emi = Loans.monthlyInstallment(p, n, r);
            System.out.printf("%-6d%16.2f%n", n, emi);
        }
    }
}
