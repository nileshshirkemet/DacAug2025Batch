package app.components;

import jakarta.servlet.ServletContextEvent;
import jakarta.servlet.ServletContextListener;
import jakarta.servlet.annotation.WebListener;

@WebListener
public class WebAppInitializer implements ServletContextListener {

    @Override
    public void contextInitialized(ServletContextEvent sce) {
        String pattern = "/" + System.getProperty("greeting.prefix", "greet") + "/*";
        sce.getServletContext()
            .addServlet("greeter", new GreetingServlet())
            .addMapping(pattern);
    }
    
    
}
