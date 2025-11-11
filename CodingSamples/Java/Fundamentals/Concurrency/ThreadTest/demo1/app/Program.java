package app;

public class Program {

    static ThreadLocal<String> manager = new ThreadLocal<>();

    static void handleJob(int jid) {
        System.out.printf("Thread<%x> has accepted job<%d> for %s%n", Thread.currentThread().hashCode(), jid, manager.get());
        Activity.perform(jid);
        System.out.printf("Thread<%x> has finished job<%d> for %s%n", Thread.currentThread().hashCode(), jid, manager.get());
    }

    public static void main(String[] args) throws Exception {
        int n = args.length > 0 ? Integer.parseInt(args[0]) : 1;
        Thread child = new Thread(() -> {
            manager.set("Jack");
            handleJob(n);
        });
        //JVM does not wait for a daemon thread to exit
        child.setDaemon(n > 5);
        child.start();
        manager.set("Jill");
        handleJob(2);
    }
}