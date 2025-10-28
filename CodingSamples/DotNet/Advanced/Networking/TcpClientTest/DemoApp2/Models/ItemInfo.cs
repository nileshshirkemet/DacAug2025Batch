namespace DemoApp.Models;

public readonly record struct ItemInfo(double Cost, int Stock)
{
    public static ItemInfo Parse(string text)
    {
        string[] segments = text.Split('&');
        double p = double.Parse(segments[0][5..]);
        int n = int.Parse(segments[1][6..]);
        return new ItemInfo(p, n);
    }
}