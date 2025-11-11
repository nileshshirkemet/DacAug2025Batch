package app;

class Activity {

    public static int perform(int balance, int amount, int op) {
        try{
            Thread.sleep(amount / 100);
        }catch(InterruptedException e){}
        return balance + op * amount;
    }
}
