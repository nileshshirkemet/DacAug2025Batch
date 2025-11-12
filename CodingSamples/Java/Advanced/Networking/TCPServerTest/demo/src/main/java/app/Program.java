package app;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

import app.models.ItemInfo;
import app.models.ShopModel;

public class Program {
    
    private static ShopModel model = new ShopModel();

    public static void main(String[] args) throws Exception {
        int port = args.length > 0 ? Integer.parseInt(args[0]) : 4010;
        System.out.printf("Starting shop-server on TCP port %d...%n", port);
        //step 1;
        start(new ServerSocket(port));
    }

    private static void start(ServerSocket listener) throws IOException {
        while(true){
            //step 2 
            var client = listener.accept();
            //communicateWith(client);
            //Thread.ofPlatform().start(() -> communicateWith(client));
            //a virtual thread is a light-weight JVM managed thread
            //which executes the specified action using a platform
            //thread from the thread-pool while releasing this platform
            //thread whenever the action is blocked by an i/o operation
            Thread.ofVirtual().start(() -> communicateWith(client));
        }
    }

    private static void communicateWith(Socket connection) {
        try{
            //Step 3
            var receiver = connection.getInputStream();
            var sender = connection.getOutputStream();
            try{
                var reader = new BufferedReader(new InputStreamReader(receiver));
                var writer = new PrintWriter(sender, true);
                //Thread.currentThread().isVirtual();
                writer.println("Welcome to EviTek computers.");
                String name = reader.readLine();
                ItemInfo info = model.getItemInfo(name);
                if(info != null)
                    writer.printf("cost=%.2f&stock=%d%n", info.cost(), info.stock());
                writer.close();
                reader.close();
            }finally{
                //Step 4
                connection.close();
            }
        }catch(Exception e){
            System.out.printf("Communication failure: %s%n", e);
        }
    }
}

