package app.components;

import java.io.IOException;
import java.util.Date;

import jakarta.servlet.Servlet;
import jakarta.servlet.ServletConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;

public class GreetingServlet implements Servlet {
    
    private ServletConfig config;

    public void init(ServletConfig cfg) throws ServletException {
        config = cfg;
    }

    public ServletConfig getServletConfig() {
        return config;
    }

    public String getServletInfo() {
        return "Simple Greeter";
    }

    public void service(ServletRequest request, ServletResponse response) throws ServletException, IOException {
        String person = request.getParameter("name");
        if(person == null)
            person = "Visitor";
        response.setContentType("text/html");
        response.getWriter().printf("""
            <html>
                <head>
                    <title>demo-app</title>
                </head>
                <body>
                    <h1>Welcome %s</h1>
                    <b>Current Time: </b>%s
                </body>
            </html>
            """, person, new Date());
    }

    public void destroy() {}
}
