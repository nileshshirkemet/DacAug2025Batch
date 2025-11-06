import banking.*;

class Program {

    //last parameter of given type declared with ... operator
    //can accept an array or a sequence of arguments of that type
    private static void payAnnualInterest(Account... accounts) {
        for(Account acc : accounts){
            if(acc instanceof Profitable p){
                double amount = p.interest(12);
                acc.deposit(amount);
            }
        }
    }

    public static void main(String[] args) {
        Account jill = Banker.openSavingsAccount();
        jill.deposit(15000);
        Account jack = Banker.openCurrentAccount();
        jack.deposit(30000);
        Account john = Banker.openSavingsAccount();
        john.deposit(35000);
        System.out.printf("Jill's Account ID is %d and Balance is %.2f%n", jill.id(), jill.balance());
        System.out.printf("Jack's Account ID is %d and Balance is %.2f%n", jack.id(), jack.balance());
        System.out.printf("John's Account ID is %d and Balance is %.2f%n", john.id(), john.balance());
        System.out.println("------------------------------------------");
        if(args.length > 0) {
            try{
                double payment = Double.parseDouble(args[0]);
                System.out.printf("Jill is making a payment of %.2f to Jack...%n", payment);
                jill.transfer(payment, jack);
            }catch(InsufficientFundsException e){
                System.out.println("Jill's payment failed due to lack of funds!");
            }catch(Exception e){
                System.out.printf("ERROR: %s%n", e.getMessage());
            }
        }else{
            System.out.println("Paying annual interest...");
            //payAnnualInterest(new Account[]{jill, jack, john});
            payAnnualInterest(jill, jack, john);
        }
        System.out.println("------------------------------------------");
        System.out.printf("Jill's closing balance: %.2f%n", jill.balance());
        System.out.printf("Jack's closing balance: %.2f%n", jack.balance());
        System.out.printf("John's closing balance: %.2f%n", john.balance());

    }
}