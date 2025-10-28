namespace DemoApp.Models;

public class ShopModel(string remote)
{
    public async ValueTask<ItemInfo> FetchItemInfoAsync(string name)
    {
        using var client = new HttpClient 
        {
            BaseAddress = new Uri($"http://{remote}/shop/")
        };
        var response = await client.GetAsync(name);
        if(response.IsSuccessStatusCode)
        {
            var message = await response.Content.ReadAsStringAsync();
            return ItemInfo.Parse(message);
        }
        return default; 
    }
}