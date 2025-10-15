if(args.Length == 0)
{
    //ICollection<Interval> store = new List<Interval>();
    //ICollection<Interval> store = new LinkedList<Interval>();
    //ICollection<Interval> store = new HashSet<Interval>();
    ICollection<Interval> store = new SortedSet<Interval>();
    store.Add(new Interval(5, 21));
    store.Add(new Interval(4, 81));
    store.Add(new Interval(6, 52));
    store.Add(new Interval(7, 43));
    store.Add(new Interval(4, 14));
    store.Add(new Interval(2, 35));
    foreach(var i in store)
        Console.WriteLine(i);
}
else
{
    //IDictionary<string, Interval> store = new Dictionary<string, Interval>();
    //IDictionary<string, Interval> store = new SortedList<string, Interval>();
    IDictionary<string, Interval> store = new SortedDictionary<string, Interval>();
    store.Add("monday", new Interval(5, 21));
    store.Add("tuesday", new Interval(6, 52));
    store.Add("wednesday", new Interval(7, 43));
    store.Add("thursday", new Interval(2, 34));
    store["friday"] = new Interval(3, 25);
    store["monday"] = new Interval(4, 21);
    string key = args[0].ToLower();
    if(store.TryGetValue(key, out Interval val))
    {
        Console.WriteLine($"Value = {val}");
    }
    else
    {
        foreach(var pair in store)
            Console.WriteLine("{0, -12}{1, 8}", pair.Key, pair.Value);
    }
}

