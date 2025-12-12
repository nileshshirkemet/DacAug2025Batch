package app.resources;
import java.util.Date;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Logger;

//import com.google.gson.Gson;

import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;

import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Request;
import jakarta.ws.rs.core.Response;
import jakarta.ws.rs.core.SecurityContext;
import app.hrms.data.*;
import app.Model.*;
import app.resources.*;;

@Path("/api/hrms")
public class EmployeeManagerApi
{
    
    @GET
    @Path("/all")
    @Produces(MediaType.APPLICATION_JSON)
    public Response readEmployees() throws Exception{
         //final Gson serializer = new Gson();
        EmployeeModel em = new EmployeeModel();
        List<EmployeeEntity>  reply = em.getAllEmployees();
               return reply.size() > 0
                ? Response.ok(reply).build()
                : Response.status(404).build();
    }

    @GET
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public Response readEmployee(@PathParam("id") int eId) throws Exception{
         //final Gson serializer = new Gson();
        System.out.println(eId);
        EmployeeModel em = new EmployeeModel();
        EmployeeEntity  reply = em.getEmployee(eId);

    
            return (reply != null)
                ? Response.ok(reply).build()
                : Response.status(404).build();
    }
    /*
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public Response createNewEmployee(EmployeeResource e) {
            EmployeeEntity e1 = new EmployeeEntity();
            e1.setEmpNo(e.getEmpno());   
            e1.setEname(e.getEname());
            e1.setJob(e.getJob());
            e1.setSal(e.getSal());
            e1.setDeptno(e.getDeptno()); 
            e.setHiredate(new Date());
         try{
            EmployeeModel emodel = new EmployeeModel(); 

            int reply = emodel.CreateEmployee(e1);     
            
            return Response.ok(e).build();
        }catch(RuntimeException ex){
            ex.printStackTrace();
            return Response.status(500,ex.getMessage()).build();
        }
    }*/

    
    @POST
    //@Path("/api/hrms/new")
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public Response createEmployee(EmployeeResource e) {
        //System.out.printf("creating employee %s(%d)...%n", entry.getEname(), entry.getEmpno());
          EmployeeEntity e1 = new EmployeeEntity();
            e1.setEmpNo(e.getEmpno());   
            e1.setEname(e.getEname());
            e1.setJob(e.getJob());
            e1.setSal(e.getSal());
            e1.setDeptno(e.getDeptno()); 
            e.setHiredate(new Date());
         try{
            EmployeeModel emodel = new EmployeeModel(); 

            int reply = emodel.CreateEmployee(e1);     
            
            return Response.ok(e).build();
        }catch(RuntimeException ex){
            ex.printStackTrace();
            return Response.status(500,ex.getMessage()).build();
        }
        //return Response.ok(entry).build();
    }
}
