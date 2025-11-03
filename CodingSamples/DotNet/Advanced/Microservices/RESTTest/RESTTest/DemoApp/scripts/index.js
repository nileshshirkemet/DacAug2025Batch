const restUri = "http://localhost:5000/api/sales";

class SalesDataSource {

    constructor() {
        this.agentLogin = {id: "", passcode: "", token: ""};
        this.orderList = [];
        this.orderEntry = {customerId: "", productNo: 0, quantity: 0};
        this.statusReport = "";        
    }

    async signInAgent(){
        let response = await fetch(`${restUri}/${this.agentLogin.id}/${this.agentLogin.passcode}`);
        if(response.ok){
            this.agentLogin.token = await response.text();
        }else{
            alert("Agent Log-In Failed!");
        }
    }

    async readOrders(){
        let request = {
            method: "get",
            headers: {
                "Authorization": "Bearer " + this.agentLogin.token
            }
        };
        let response = await fetch(`${restUri}/${this.orderEntry.customerId}`, request);
        if(response.ok){
            this.orderList = await response.json();
            this.statusReport = "";
        }else{
            this.orderList = [];
            this.statusReport = "Cannot fetch orders!"
        }
    }

    async createOrder(){
        this.orderList = [];
        let request = {
            method: "post",
            headers: {
                "Authorization": "Bearer " + this.agentLogin.token,
                "Content-Type": "application/json"
            },
            body: JSON.stringify(this.orderEntry)
        };
        let response = await fetch(restUri, request);
        if(response.ok){
            let result = await response.json();
            this.statusReport = `Order ${result.orderNo} placed.`;
        }else{
            this.statusReport = "Cannot place order!";
        }
    }
}