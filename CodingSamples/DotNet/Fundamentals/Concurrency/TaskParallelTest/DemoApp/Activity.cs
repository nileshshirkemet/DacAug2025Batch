namespace DemoApp;

static class Activity
{
    public static long Perform(int count)
    {
        long scale = count;
        int goal = Environment.TickCount + 100 * count;
        while(Environment.TickCount < goal);
        return scale * count;
    }
}
