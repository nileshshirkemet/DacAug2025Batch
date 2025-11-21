package app.services;

import java.util.Iterator;

import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;
import sales.OrderManagerGrpc;
import sales.OrderManagerOuterClass.CustomerInput;
import sales.OrderManagerOuterClass.CustomerOrder;
import sales.OrderManagerOuterClass.OrderInput;
import sales.OrderManagerOuterClass.OrderStatus;

public class OrderManagerProxy implements AutoCloseable {
    
    private final ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 4030)
        .usePlaintext()
        .build();

    public OrderStatus placeOrder(OrderInput request) {
        return OrderManagerGrpc.newBlockingStub(channel)
            .placeOrder(request);
    }

    public Iterator<CustomerOrder> fetchOrders(CustomerInput request) {
        return OrderManagerGrpc.newBlockingStub(channel)
            .fetchOrders(request);
    }

    public void close() {
        channel.shutdown();
    }
}
