package app;

class Activity {

    public static void perform(int count) {
        long goal = System.currentTimeMillis() + 1000 * count;
        while(System.currentTimeMillis() < goal);
    }
}
