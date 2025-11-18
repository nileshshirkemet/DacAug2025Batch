<%@ taglib prefix="d" uri="demo.app.tags" %>
<html>
	<head>
		<title>demo-app</title>
	</head>
	<body>
		<h1>Welcome Customer</h1>
		<hr/>
		<h2>Please Sign-In</h2>
		<form method="post">
			<p>
				<b>Customer ID</b><br/>
				<input required type="text" name="custId" />
			</p>
			<p>
				<b>Password</b><br/>
				<input required type="password" name="custPwd" />
			</p>
			<p>
				<input type="submit" value="Login" />
			</p>
		</form>
		<p>
			<b>${requestScope.problem}</b>
		</p>
		<hr/>
		<d:putCurrentTime format="yyyy-MM-dd HH:mm:ss"/>
	</body>
</html>


