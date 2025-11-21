package app.resources;

import app.security.JwtHelper;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.core.Response;
import jakarta.ws.rs.core.Response.Status;

@Path("/api/sales")
public class SalesAgentApi {
    
    @GET
    @Path("/{id}/{code}")
    public Response signIn(@PathParam("id") String agentId, @PathParam("code") int passcode) {
        if(passcode == 9820){
            String token = JwtHelper.createToken(agentId);
            return Response.ok(token).build();
        }
        return Response.status(Status.UNAUTHORIZED).build();
    }
}
