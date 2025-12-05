// event listener
document.querySelector('button').addEventListener("click" , function(){
    let record = document.getElementById('x1').value;
    console.log(record);
    if(record!=""){
        //AJAX OPERATION STARTED
        const XHR = new XMLHttpRequest();
        console.log(XHR);
        console.log(XHR.readyState,XHR.status);
        //XHR.readyState ==0  No request is initialized (not connect to apis)
        //status -- HTTP CODE
        XHR.onreadystatechange = function(){
            console.log(XHR.readyState,XHR.status);

            if(XHR.readyState==4 && XHR.status==200){
                let result = XHR.responseText;
                console.log(result);
                let value = JSON.parse(result);
                console.log(value);
                console.log(value.main.temp);
                
                let tempd = value.main.temp - 273.15;
                console.log(tempd);
                document.getElementById('result').innerHTML = ` 
                TEMP in Degree C = ${tempd.toFixed(2)} ,    CITY : ${record.toUpperCase()}
                `;   
            }
            
        }

        XHR.open("get",`https://api.openweathermap.org/data/2.5/weather?q=${record}&appid=ac0b4eccb96a874a2a714d2967fd27f2`);
        //1==> request has been setup 
        XHR.send();
        //2 ==> request has been sent to the server
        //3 ==> request is in progress
        //4 ==> request cycle completed
    }
});