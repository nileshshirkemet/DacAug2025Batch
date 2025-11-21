package app.security;

import java.io.IOException;
import java.security.Principal;

import jakarta.ws.rs.container.ContainerRequestContext;
import jakarta.ws.rs.container.ContainerRequestFilter;
import jakarta.ws.rs.core.Response;
import jakarta.ws.rs.core.SecurityContext;
import jakarta.ws.rs.ext.Provider;

@Provider
@AuthorizationCheck
public class AuthorizationFilter implements ContainerRequestFilter{

    @Override
    public void filter(ContainerRequestContext requestContext) throws IOException {
        try{
            String token = requestContext.getHeaderString("Authorization")
                .substring("Bearer ".length());
            String userId = JwtHelper.validateToken(token);
            requestContext.setSecurityContext(new SecurityContext() {

                @Override
                public Principal getUserPrincipal() {
                    return () -> userId;
                }

                @Override
                public boolean isUserInRole(String role) {
                    return true;
                }

                @Override
                public boolean isSecure() {
                    return false;
                }

                @Override
                public String getAuthenticationScheme() {
                    return "Bearer";
                }
                
            });
        }catch(Exception e){
            requestContext.abortWith(Response.status(401).build());
        }
    }
    
}
