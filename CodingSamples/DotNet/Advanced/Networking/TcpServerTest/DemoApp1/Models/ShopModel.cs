using System.Text.Json;

namespace DemoApp.Models;

public class ShopModel
{
    private IEnumerable<ItemInfo> items;

    public ShopModel()
    {
        items = Load("EviTek.store");
    }

    public ItemInfo GetItemInfo(string name)
    {
        return items.FirstOrDefault(i => i.Id == name);
    }

    public static void Save(string document, ItemInfo[] entries)
    {
        using var output = new FileStream(document, FileMode.Create);
        //serialization - convverting objects into stream of bytes
        JsonSerializer.Serialize(output, entries);
    }

    public static ItemInfo[] Load(string document)
    {
        using var input = new FileStream(document, FileMode.Open);
        //deserialization - converting stream of bytes into objects
        return JsonSerializer.Deserialize<ItemInfo[]>(input);
    }
}