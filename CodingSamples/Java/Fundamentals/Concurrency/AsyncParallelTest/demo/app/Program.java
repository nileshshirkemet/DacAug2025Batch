package app;

import java.util.concurrent.CompletableFuture;
import java.util.stream.IntStream;

public class Program {

    static class Computation {

        private long start;

        public long compute(int first, int last) {
            start = System.nanoTime();
            return IntStream.range(first, last + 1)
                .parallel() //split incoming stream into sub-streams
                .mapToLong(Activity::perform)
                .sum();
        }

        public CompletableFuture<Long> computeAsync(int first, int second) {
            //the supplied operation is scheduled to execute on a worker thread
            //from the thread-pool allowing the caller thread to resume execution
            //and obtain the result in future after the worker has completed
            //the operation
            return CompletableFuture.supplyAsync(() -> compute(first, second));
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
        var job = c.computeAsync(1, n)
            .thenAccept(r -> {
                System.out.println("Done!");
                System.out.printf("Result = %d, computed in %.3f seconds.%n", r, c.time());    
            });
        while(!job.isDone()){
            System.out.print(".");
            Thread.sleep(500);
        }
    }
}
