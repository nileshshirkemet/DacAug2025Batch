import taxation.Supervisor;
import taxation.Worker;

class Program {

    private static void doAuditing(String name, int count) {
        //close() method of a variable of AutoCloseable type
        //initialized within scope of try-with-resource statement
        //is automatically called at the end of this scope
        try(var a = new Auditor()){
            if(count <= 10)
                a.audit(name, new Supervisor(count));
            else
                a.audit(name, new Worker(count));
        }
        
    }

    public static void main(String[] args) {
        try{
            String m = args[0].toUpperCase();
            int n = Integer.parseInt(args[1]);
            doAuditing(m, n);
        }catch(Exception e){
            System.out.printf("Error: %s%n", e.getMessage());
        }
    }
}