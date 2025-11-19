package app;

import app.services.shopping.OrderManagerService;
import io.grpc.ServerBuilder;

public class Program {
    
    public static void main(String[] args) throws Exception {
        System.out.println("Starting server on HTTP/2 port 4030...");
        ServerBuilder.forPort(4030)
            .addService(new OrderManagerService())
            .build()
            .start()
            .awaitTermination();
    }
}

