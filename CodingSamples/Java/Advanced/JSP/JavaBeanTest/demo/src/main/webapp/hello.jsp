<jsp:useBean id="greeter" class="app.components.GreeterBean" scope="session" />
<jsp:setProperty name="greeter" property="person" param="user" />
<jsp:setProperty name="greeter" property="period" />
<html>
    <head>
        <title>demo-app</title>
    </head>
    <body>
        <h1>${greeter.message}</h1>
        <form method="post">
            <p>
                <b>Person: </b>
                <input type="text" name="user" />
            </p>
            <p>
                <b>Period: </b>
                <select name="period">
                    <option>Night</option>
                    <option>Morning</option>
                    <option>Afternoon</option>
                    <option>Evening</option>
                </select>
            </p>
            <p>
                <input type="submit" value="Greet" />
            </p>
        </form>
        <b>Number of Greetings: </b>${greeter.greetCount}
    </body>
</html>
