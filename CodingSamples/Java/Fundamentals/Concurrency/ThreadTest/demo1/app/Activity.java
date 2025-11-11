package app;

class Activity {

    public static void perform(int count) {
        try{
            Thread.sleep(1000 * count);
        }catch(InterruptedException e){}
    }
}
