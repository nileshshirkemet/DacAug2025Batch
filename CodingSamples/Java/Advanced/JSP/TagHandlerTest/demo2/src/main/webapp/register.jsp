<%@ taglib prefix="c" uri="jakarta.tags.core" %>
<jsp:useBean id="site" class="app.tourism.models.SiteModel" scope="application" />
<html>
    <head>
        <title>demo-app</title>
    </head>
    <body>
        <h1>Welcome Visitor</h1>
        <h2>Register Visit</h2>
        <form method="post">
            <p>
                <b>Your Name: </b>
                <input required type="text" name="visitorId" />
            </p>
            <p>
                <b>Experience: </b>
                <select name="visitorRating">
                    <option value="5">Fantastic</option>
                    <option value="4">Fine</option>
                    <option value="3">Average</option>
                    <option value="2">Poor</option>
                    <option value="1">Pathetic</option>
                </select>
            </p>
            <p>
                <input type="submit" value="Apply" />
            </p>
            <c:if test="${site.handleVisit(param.visitorId, param.visitorRating)}">
                <c:redirect url="index.jsp" />
            </c:if>
        </form>
        <p>
            <a href="index.jsp">Our Visitors</a>
        </p>
    </body>
</html>