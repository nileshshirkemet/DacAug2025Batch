package app.models;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.stream.Stream;

import com.fasterxml.jackson.databind.ObjectMapper;

public class ShopModel {

    private ItemInfo[] items;

    public ShopModel() {
        items = load("EviTek.store");
    }

    public ItemInfo getItemInfo(String name) {
        return Stream.of(items)
            .filter(i -> i.id().equals(name))
            .findFirst()
            .orElse(null);
    }
    
    public static void save(String document, ItemInfo[] entries) {
        var serializer = new ObjectMapper();
        try(var output = new FileOutputStream(document)){
            serializer.writeValue(output, entries);
        }catch(IOException e){
            throw new RuntimeException(e);
        }
    }

    public static ItemInfo[] load(String document) {
        var serializer = new ObjectMapper();
        try(var input = new FileInputStream(document)){
            return serializer.readValue(input, ItemInfo[].class);
        }catch(IOException e){
            throw new RuntimeException(e);
        }
    }
}
