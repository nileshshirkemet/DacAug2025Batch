namespace DemoApp;

static class Activity
{
    public static void Perform(int count)
    {
        int goal = Environment.TickCount + count * 1000;
        while(Environment.TickCount < goal);

    }
}