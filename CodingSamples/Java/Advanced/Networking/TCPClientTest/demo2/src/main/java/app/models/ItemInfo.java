package app.models;

import java.net.http.HttpResponse.BodyHandler;
import java.net.http.HttpResponse.BodySubscribers;
import java.nio.charset.StandardCharsets;

public record ItemInfo(double cost, int stock) {
    
    public static ItemInfo parse(String text) {
        String[] segments = text.split("&");
        double p = Double.parseDouble(segments[0].substring(5));
        int n = Integer.parseInt(segments[1].substring(6));
        return new ItemInfo(p, n);
    }

    public static BodyHandler<ItemInfo> bodyHandler() {
        return response -> {
            if(response.statusCode() == 200){
                return BodySubscribers.mapping(
                    BodySubscribers.ofString(StandardCharsets.UTF_8), 
                    ItemInfo::parse
                );
            }
            return BodySubscribers.replacing(new ItemInfo(0, 0));
        };
    }
}
