using System.Net;
using System.Net.Sockets;
using DemoApp.Models;

namespace DemoApp;

class ShopServer(ShopModel model)
{
    public void Run()
    {
        //Step 1
        var listener = new TcpListener(IPAddress.Any, 4010);
        listener.Start();
        while(true)
        {
            //Step 2
            var client = listener.AcceptTcpClient();
            CommunicateWith(client);
        }
    }

    private void CommunicateWith(TcpClient connection)
    {
        try
        {
            //Step 3
            var channel = connection.GetStream();
            using var reader = new StreamReader(channel);
            using var writer = new StreamWriter(channel){AutoFlush = true};
            writer.WriteLine("Welcome to EviTek Computers");
            string item = reader.ReadLine();
            ItemInfo info = model.GetItemInfo(item);
            if(info != null)
                writer.WriteLine($"cost={info.Cost}&stock={info.Stock}");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Communication Failure: {0}", ex.Message);
        }
        //Step 4
        connection.Close();
    }
}