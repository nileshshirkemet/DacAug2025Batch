using System.Net.Sockets;

namespace DemoApp.Models;

public class ShopModel(string remote)
{
    public async ValueTask<ItemInfo> FetchItemInfoAsync(string name)
    {
        //Step 1
        var client = new TcpClient(remote, 4010);
        //Step 2
        var channel = client.GetStream();
        using var reader = new StreamReader(channel);        
        using var writer = new StreamWriter(channel) { AutoFlush = true };
        await reader.ReadLineAsync(); //receive and ignore greeting message
        await writer.WriteLineAsync(name);
        string message = await reader.ReadLineAsync();
        //Step 3
        client.Close();
        if(message != null)
            return ItemInfo.Parse(message);
        return default; //new ItemInfo();
    }
}