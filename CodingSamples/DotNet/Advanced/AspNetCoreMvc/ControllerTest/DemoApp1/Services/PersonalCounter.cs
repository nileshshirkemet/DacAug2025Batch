namespace DemoApp.Services;

public class PersonalCounter : IVisitCounter
{
    private Dictionary<string, int> store = [];

    public int CountNext(string id)
    {
        lock(store)
        {
            store.TryGetValue(id, out int current);
            store[id] = ++current;
            return current;
        }
    }
}