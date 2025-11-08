package app;

import finance.Loans;

public class Program {
    
    public static void main(String[] args) {
        System.out.println(Loans.monthlyInstallment(500000, 10, 9));
    }
}
