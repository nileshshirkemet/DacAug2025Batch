package app.resources;

import java.util.ArrayList;

import app.services.OrderManagerProxy;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;
import sales.OrderManagerOuterClass.CustomerInput;

@Path("/api/sales")
public class OrderManagerApi {
    
    @GET
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public Response readOrders(@PathParam("id") String customerId) {
        try(var remote = new OrderManagerProxy()){
            var request = CustomerInput.newBuilder()
                .setCustomerCode(customerId)
                .build();
            var reply = remote.fetchOrders(request);
            var resources = new ArrayList<OrderEntry>();
            reply.forEachRemaining(message -> {
                var resource = new OrderEntry();
                resource.setProductNo(message.getItemCode());
                resource.setQuantity(message.getItemCount());
                resource.setOrderDate(message.getConfirmationDate());
                resources.add(resource);
            });
            return resources.size() > 0
                ? Response.ok(resources).build()
                : Response.status(404).build();
        }
    }
}
