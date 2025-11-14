package app;

import java.util.Properties;

import app.shopping.data.ProductEntity;
import jakarta.persistence.Persistence;

public class Program {
    
    public static void main(String[] args) throws Exception {
        var settings = new Properties();
        if(args[0].equals("server")){
            settings.put("jakarta.persistence.jdbc.url", "jdbc:oracle:thin:@//metiitdac.met.edu/xepdb1");
            settings.put("jakarta.persistence.jdbc.user", "dac");
            settings.put("jakarta.persistence.jdbc.password", "metiit");
        }else{
            settings.put("jakarta.persistence.jdbc.url", "jdbc:mysql://localhost/sales");
            settings.put("jakarta.persistence.jdbc.user", "root");
            settings.put("jakarta.persistence.jdbc.password", "root");
        }
        var emf = Persistence.createEntityManagerFactory("app.data", settings);
        var em = emf.createEntityManager();
        if(args.length < 2){
            var query = em.createQuery("SELECT p FROM ProductEntity p", ProductEntity.class);
            for(var entry : query.getResultList()){
                System.out.printf("%d\t%.2f\t%d%n", entry.getProductNo(), entry.getPrice(), entry.getStock());
            }
        }else{
            int id = Integer.parseInt(args[1]);
            var product = em.find(ProductEntity.class, id);
            if(product != null){
               for(var entry : product.getOrders()){
                    System.out.printf("%s\t%d\t%tF%n", entry.getCustomerId(), entry.getQuantity(), entry.getOrderDate());
                }
            }else{
                System.out.println("No such product!");
            }
        }
        em.close();
    }
}

