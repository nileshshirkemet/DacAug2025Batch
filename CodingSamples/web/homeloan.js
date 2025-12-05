function calculate(){
    // alert(111);  
    // confirm('delete?');
    // prompt('Enter Number'); 

    let amount = document.getElementById('x1').value;
    let roi = document.getElementById('x2').value;
    let duration = document.getElementById('x3').value;
    console.log(amount,roi,duration);
    console.log(isNaN(amount));
    
    if(amount=="" || isNaN(amount) || amount<=0){
        document.querySelector('p').innerHTML='Invalid Amount';
        document.querySelector('p').style.color='red';
    }
    else if(roi=="" || isNaN(roi) || roi<=0){
        document.querySelector('p').innerHTML='Invalid Roi';
        document.querySelector('p').style.color='red';
    }
    else if(duration=="" || isNaN(duration) || duration<=0){
        document.querySelector('p').innerHTML='Invalid duration';
        document.querySelector('p').style.color='red';
    }
    else{
        console.log(typeof amount);
        //typecasting -- type conversion
        amount = parseFloat(amount);
        roi = Number(roi);
        duration = parseInt(duration);

        let P = amount;
        let R = roi/12/100;
        let N = duration*12;

        let emi = P * R * (1+R)**N / ((1+R)**N-1)
        console.log(emi , Math.round(emi));
        
        console.log(document.getElementsByTagName('span'));
        
        document.getElementsByTagName('span')[0].innerHTML = `EMI : ${emi.toFixed(2)}`;
        document.getElementsByTagName('span')[1].innerHTML = `Total Paid : ${emi*N}`;
        document.getElementsByTagName('span')[2].innerHTML = `Interest Paid : ${emi*N - P}`;
        document.getElementsByTagName('span')[3].innerHTML = `Loan Amount : ${P}`;
    }
}