document.querySelector('button').addEventListener("click",async function(){
    let data1 = document.getElementById('x1').value;
    let data2 = document.getElementById('x2').value;
    //console.log(data1,data2);
    let regexpEmail = /^([A-z0-9_\.]+)@([A-z0-9\-]+)\.([A-z]{2,})$/;
    let regexpPassword = /^(?=.*[a-z])(?=.*[\d])(?=.*[A-Z])(?=.*[@#\{\-\^\$]).{4,8}$/;

    if(!regexpEmail.test(data1) || !regexpPassword.test(data2)){
        document.getElementById('result').innerText = 'Invalid Email or Password';
    }
    else{
        try{
            let apivalue = await fetch('https://fakestoreapi.com/users');
            let result= await apivalue.json();
            console.log(result);

            document.getElementById('result').innerText =  result.filter( value=>value.email==data1 && value.password==data2 ).length==0 ?  "Invalid Credential" : "Valid Credential";
        }
        catch(err){
        }
    }
});