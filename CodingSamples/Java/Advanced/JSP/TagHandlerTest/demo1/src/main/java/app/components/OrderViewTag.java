package app.components;

import java.io.IOException;
import java.util.List;

import jakarta.servlet.jsp.JspException;
import jakarta.servlet.jsp.tagext.SimpleTagSupport;

public class OrderViewTag extends SimpleTagSupport {

    private String orderVar;

    private List<OrderEntry> orderSource;

    public void setOrderVar(String orderVar) {
        this.orderVar = orderVar;
    }

    public void setOrderSource(List<OrderEntry> orderSource) {
        this.orderSource = orderSource;
    }

    @Override
    public void doTag() throws JspException, IOException {
        var context = super.getJspContext();
        var body = super.getJspBody();
        for(var orderVal : orderSource){
            context.setAttribute(orderVar, orderVal);
            body.invoke(null);
        }
    }

    
    
}
