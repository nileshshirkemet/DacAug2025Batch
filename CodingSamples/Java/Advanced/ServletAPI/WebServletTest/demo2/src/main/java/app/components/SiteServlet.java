package app.components;

import java.io.IOException;

import com.google.gson.Gson;

import app.tourism.models.SiteModel;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/api/feedbacks")
public class SiteServlet extends HttpServlet {
    
    public static record Feedback(String person, int rating){}

    private SiteModel model = new SiteModel();
    private Gson serializer = new Gson();

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        var visitors = model.getVisitors();
        serializer.toJson(visitors, response.getWriter());
    }

    @Override
    protected void doPut(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        var input = serializer.fromJson(request.getReader(), Feedback.class);
        if(!model.handleVisit(input.person(), input.rating()))
            response.sendError(400); //bad request
    }

    
}
