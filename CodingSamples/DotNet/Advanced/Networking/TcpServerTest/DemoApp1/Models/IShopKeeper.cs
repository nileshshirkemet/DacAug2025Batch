namespace DemoApp.Models;

public interface IShopKeeper
{
    ItemInfo GetItemInfo(string name);
}