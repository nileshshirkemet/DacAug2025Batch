package app.components;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.concurrent.atomic.AtomicInteger;

import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class GreetingServlet extends HttpServlet {

    private AtomicInteger counter = new AtomicInteger();

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String pinfo = request.getPathInfo();
        String name = pinfo != null ? pinfo.substring(1) : "Friend";
        int count = counter.incrementAndGet();
        var application = super.getServletContext();
        String page = request.getHeader("User-Agent").contains("Mobile")
            ? application.getRealPath("/WEB-INF/templates/hello.html")
            : application.getRealPath("/WEB-INF/templates/welcome.html");
        String content = Files.readString(Path.of(page))
            .replace("|visitor.name|", name)
            .replace("|visit.count|", String.valueOf(count));
        response.setContentType("text/html");
        response.getWriter().write(content);

    }
    
    
}
