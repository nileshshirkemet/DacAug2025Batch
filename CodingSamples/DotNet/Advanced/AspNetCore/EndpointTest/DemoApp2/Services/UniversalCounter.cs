namespace DemoApp.Services;

public class UniversalCounter : IVisitCounter
{
    private static int current = 0;

    public int CountNext(string id)
    {
        return Interlocked.Increment(ref current);
    }
}