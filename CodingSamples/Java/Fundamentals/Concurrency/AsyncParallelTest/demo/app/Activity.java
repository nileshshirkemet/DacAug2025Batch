package app;

class Activity {

    public static long perform(int count) {
        long scale = count;
        try{
            Thread.sleep(100 * count);
        }catch(InterruptedException e){}
        return scale * count;
    }
}
