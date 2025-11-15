package app.components;

import java.io.IOException;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/login")
public class CountingServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String name = request.getParameter("person");
        if(name.length() == 0)
            name = "Friend";
        var session = request.getSession(true);
        Integer count = (Integer) session.getAttribute(name);
        if(count == null)
            count = 1;
        response.setContentType("text/html");
        response.getWriter().printf("""
            <html>
                <head>
                    <title>demo-app</title>
                </head>
                <body>
                    <h1>Hello %s</h1>
                    <b>Number of Greetings: </b>%d
                </body>
            </html>
            """, name, count);
        session.setAttribute(name, count + 1);
        if(count > 5)
            session.invalidate();
    }
    
    
}
