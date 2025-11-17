package app.components;

import java.io.IOException;

import jakarta.servlet.Filter;
import jakarta.servlet.FilterChain;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;

public class PausingFilter implements Filter {
    
    private long recent = 0;

    public void doFilter(ServletRequest request, ServletResponse response, FilterChain next) throws IOException, ServletException {
        long current = System.currentTimeMillis();
        if(current - recent > 3000){
            next.doFilter(request, response);
            recent = current;
        }else{
            response.getWriter().println("Server busy, try after some time...");
        }
    }
}
