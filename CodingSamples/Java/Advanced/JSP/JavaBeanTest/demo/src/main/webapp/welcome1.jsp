<%
	String person = request.getParameter("user");
	if(person == null)
		person = "";
%>
<html>
	<head>
		<title>demo-app</title>
	</head>
	<body>
		<h1>Welcome Visitor <%=person%></h1>
		<b>Current Time: </b><%=new java.util.Date()%>
	</body>
</html>

