package app.components;

import java.io.CharArrayWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Date;

import jakarta.servlet.Filter;
import jakarta.servlet.FilterChain;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;
import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpServletResponseWrapper;

@WebFilter("*.html")
public class ClockingFilter implements Filter {

    @Override
    public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain) throws IOException, ServletException {
        var originalResponse = (HttpServletResponse) response;
        var capture = new CharArrayWriter();
        var wrappedResponse = new HttpServletResponseWrapper(originalResponse) {
            public PrintWriter getWriter() {
                return new PrintWriter(capture);
            }
        };
        var out = originalResponse.getWriter();
        chain.doFilter(request, wrappedResponse);
        capture.writeTo(out);
        out.printf("<hr/><i>%s</i>", new Date());
    }
    
    
}
