namespace DemoApp;

static class Activity
{
    public static int Perform(int balance, int amount, int op)
    {
        int goal = Environment.TickCount + amount / 100;
        while(Environment.TickCount < goal);
        return balance + op * amount;
    }
}