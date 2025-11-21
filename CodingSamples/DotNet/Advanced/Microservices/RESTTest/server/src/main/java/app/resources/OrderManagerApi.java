package app.resources;

import java.util.ArrayList;
import java.util.logging.Logger;

import app.security.AuthorizationCheck;
import app.services.OrderManagerProxy;
import io.grpc.StatusRuntimeException;
import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.Context;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;
import jakarta.ws.rs.core.SecurityContext;
import sales.OrderManagerOuterClass.CustomerInput;
import sales.OrderManagerOuterClass.OrderInput;

@Path("/api/sales")
public class OrderManagerApi {
    
    @GET
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    @AuthorizationCheck
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

    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @AuthorizationCheck
    public Response createOrder(OrderEntry resource, @Context SecurityContext securityContext) {
        try(var remote = new OrderManagerProxy()){
            var request = OrderInput.newBuilder()
                .setCustomerCode(resource.getCustomerId())
                .setItemCode(resource.getProductNo())
                .setItemCount(resource.getQuantity())
                .build();
            var reply = remote.placeOrder(request);
            int orderNo = reply.getConfirmationCode();
            var user = securityContext.getUserPrincipal();
            if(user != null)
                Logger.getGlobal().info(String.format("Order %d placed by %s", orderNo, user.getName()));
            resource.setOrderNo(orderNo);
            return Response.ok(resource).build();
        }catch(StatusRuntimeException e){
            return Response.status(500, e.getStatus().getDescription()).build();
        }
    }
}
