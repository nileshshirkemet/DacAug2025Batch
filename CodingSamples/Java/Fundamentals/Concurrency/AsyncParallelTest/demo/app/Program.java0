package app;

import java.util.stream.IntStream;

public class Program {

    static class Computation {

        private long start;

        public long compute(int first, int last) {
            start = System.nanoTime();
            return IntStream.range(first, last + 1)
                .mapToLong(Activity::perform)
                .sum();
        }

        public double time() {
            long stop = System.nanoTime();
            return (stop - start) / 1e9;
        }
    }
    
    public static void main(String[] args) throws Exception {
        int n = Integer.parseInt(args[0]);
        System.out.print("Computing...");
        var c = new Computation();
        long r = c.compute(1, n);
        System.out.println("Done!");
        System.out.printf("Result = %d, computed in %.3f seconds.%n", r, c.time());
    }
}
