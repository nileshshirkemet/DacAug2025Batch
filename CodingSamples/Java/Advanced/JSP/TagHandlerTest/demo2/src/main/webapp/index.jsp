<%@ taglib prefix="c" uri="jakarta.tags.core" %>
<jsp:useBean id="site" class="app.tourism.models.SiteModel" scope="application" />
<html>
	<head>
		<title>demo-app</title>
	</head>
	<body>
		<h1>Welcome Visitor</h1>
		<h2>Our Visitors</h2>
		<table border="1">
			<tr>
				<th>Visitor Name</th>
				<th>Visit Count</th>
				<th>Recent Visit</th>
				<th>Star Rating</th>
			</tr>
			<c:forEach var="visitor" items="${site.visitors}">
				<tr>
					<td>${visitor.name()}</td>
					<td>${visitor.visits()}</td>
					<td>${visitor.recent()}</td>
					<td>${visitor.stars()}</td>
				</tr>
			</c:forEach>
		</table>'
		<p>
			<a href="register.jsp">Register Visit</a>
		</p>
	</body>
</html>

