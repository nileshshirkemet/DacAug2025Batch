static class Generator
{
    public static IEnumerable<Interval> GenerateIntervals(int count)
    {
        for(int i = 0; i < count; ++i)
        {
            int t = Random.Shared.Next(100, 500);
            //each value returned by a method using 'yield' statement 
            //can be received by the caller in the same sequence through
            //an auto-generated implementation of IEnumerable<T> interface
            //specified in its return type 
            yield return new Interval(0, t);
        }
    }
}