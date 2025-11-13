package app.models;

import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;

public class ShopModel {
    
    private String server;

    public ShopModel(String remote) {
        server = remote;
    }

    public ItemInfo fetchItemInfo(String name) throws IOException, InterruptedException {
        var url = URI.create("http://" + server + "/shop/" + name);
        var client = HttpClient.newHttpClient();
        var request = HttpRequest.newBuilder(url)
            .GET()
            .header("User-Agent", "TCPClientTest demo/2.0")
            .build();
        var response = client.send(request, ItemInfo.bodyHandler());
        return response.body();

    }
}
