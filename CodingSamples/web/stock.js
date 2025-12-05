//DOM Event Handling
document.querySelector('button').onclick=function(){
    let unit1 = document.getElementById('x1').value
    let amount1 = document.getElementById('x2').value;
    let unit2 = document.getElementById('x3').value;
    let amount2 = document.getElementById('x4').value;
    console.log(unit1,unit2,amount1,amount2);

    if(unit1=="" || unit2=="" || amount1=="" || amount2=="" || isNaN(unit1) ||  isNaN(unit2) ||  isNaN(amount1) ||  isNaN(amount2)){
        document.querySelector('p').innerHTML = 'Invalid data';
    }
    else{
        unit1 = parseInt(unit1);
        unit2 = parseInt(unit2);
        amount1 = parseFloat(amount1);
        amount2 = parseFloat(amount2);

        let total = (unit1*amount1) + (unit2*amount2);
        let totalStock = unit1+unit2;
        let avgValue = total/totalStock;

        document.querySelector('p').innerHTML = `
            TOTAL PURCHASE VALUE: &#8377; ${total}<br />
            TOTAL UNIT VALUE: ${totalStock}<br />
            AVERAGE VALUE: ${avgValue}<br />
        `;
    }
}