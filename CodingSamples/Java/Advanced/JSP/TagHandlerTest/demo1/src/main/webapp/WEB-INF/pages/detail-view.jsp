<%@ taglib prefix="d" uri="demo.app.tags" %>
<jsp:useBean id="customer" class="app.components.CustomerModelBean" scope="request" />
<html>
	<head>
		<title>demo-app</title>
	</head>
	<body>
		<h1>Welcome Customer</h1>
		<hr/>
		<h2>Orders for ${customer.id}</h2>
        <table border="1">
            <tr>
                <th>Product No</th>
                <th>Quantity</th>
                <th>Order Date</th>
            </tr>
            <d:fetchNextOrder orderVar="entry" orderSource="${customer.orders}">
                <tr>
                    <td>${entry.productNo}</td>
                    <td>${entry.quantity}</td>
                    <td>${entry.orderDate}</td>
                </tr>
            </d:fetchNextOrder>
        </table>
        <p>
            <a href="/">Logout</a>
        </p>
	</body>
    <hr/>
    <d:putCurrentTime format="yyyy-MM-dd HH:mm:ss" />
</html>


