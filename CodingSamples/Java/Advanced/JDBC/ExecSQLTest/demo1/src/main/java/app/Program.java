package app;

import java.sql.DriverManager;

public class Program {
    
    public static void main(String[] args) throws Exception {
        var con = DriverManager.getConnection("jdbc:mysql://localhost/sales", "root", "root");
        var stmt = con.createStatement();
        if(args.length == 0){
            var rs = stmt.executeQuery("select pno, price, stock from products");
            while(rs.next()){
                System.out.printf("%d\t%.2f\t%d%n", rs.getInt(1), rs.getDouble(2), rs.getInt("stock"));
            }
            rs.close();
        }else{
            int id = Integer.parseInt(args[0]);
            int n = stmt.executeUpdate("update products set stock=stock+5 where pno=" + id);
            if(n == 0)
                System.out.println("No such product!");
        }
        stmt.close();
        con.close();
    }

}

