package app.Model;

import app.hrms.data.*;

import java.util.List;
//import java.util.Date;
import java.util.Properties;

//import app.shopping.data.ProductEntity;
//import app.hrms.data.*;
import jakarta.persistence.Persistence;
import jakarta.persistence.TypedQuery;

public class EmployeeModel {

    //static Properties settings = new Properties();
    /*
    static {
        settings.put("jakarta.persistence.jdbc.url", "jdbc:oracle:thin:@//iitdac.met.edu/xepdb1");
        settings.put("jakarta.persistence.jdbc.user", "dac2");
        settings.put("jakarta.persistence.jdbc.password", "metiit");
    }*/

    public  List<EmployeeEntity> getAllEmployees() throws Exception {
        //settings = new Properties();
        var emf = Persistence.createEntityManagerFactory("app.data");
        var em = emf.createEntityManager();
        var query = em.createQuery("SELECT e FROM EmployeeEntity e", EmployeeEntity.class);
        var emplist =  query.getResultList();
        em.close();
        return emplist;        
       
    }

    
    public  EmployeeEntity getEmployee(int id) throws Exception {
        //settings = new Properties();
        var emf = Persistence.createEntityManagerFactory("app.data");
        var em = emf.createEntityManager();
        /*TypedQuery<Product> query = em.createQuery("SELECT p FROM Product p WHERE p.price > :minPrice", Product.class);
         query.setParameter("minPrice", 50.0);
         query.setParameter("categoryName", "Electronics");*/
        var query = em.createQuery("SELECT e FROM EmployeeEntity e where e.empNo = :no", EmployeeEntity.class);
        query.setParameter("no", id);
        var emplist =  query.getResultList(); 
        var emp = emplist.get(0);
        em.close();
        return emp;        
       
    }

    
    public int CreateEmployee(EmployeeEntity e ) {
        if(e == null)
            return -1;
        var emf = Persistence.createEntityManagerFactory("app.data");
        try(var em = emf.createEntityManager()){
           
            var tx = em.getTransaction();
            tx.begin();
            em.persist(e);
            tx.commit();

            return e.getEmpNo();
        }
    }



}


    