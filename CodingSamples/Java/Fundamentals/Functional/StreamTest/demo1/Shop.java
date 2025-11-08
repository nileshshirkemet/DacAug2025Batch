import java.util.ArrayList;
import java.util.Collection;

record Item(String name, String brand){}

record Customer(String id, double purchase, int rating) implements Comparable<Customer> {

    public int compareTo(Customer that) {
        return id.compareTo(that.id);
    }
}

class Shop {
    
    public static Item[] getItems() {
        return new Item[]{
            new Item("cpu", "intel"),
            new Item("ssd", "sandisk"),
            new Item("ddr", "samsung"),
            new Item("cpu", "amd"),
            new Item("motherboard", "intel"),
            new Item("ssd", "samsung"),
            new Item("keyboard", "logitek"),
            new Item("mouse", "microsoft"),
            new Item("monitor", "samsung"),
            new Item("mouse", "logitek")
        };
    }

    public static Collection<Customer> getCustomers() {
        var customers = new ArrayList<Customer>();
        customers.add(new Customer("Anshul", 45000, 3));
        customers.add(new Customer("Jayesh", 68000, 4));
        customers.add(new Customer("Faizal", 39000, 2));
        customers.add(new Customer("Rehan", 52000, 3));
        customers.add(new Customer("Eshan", 78000, 5));
        customers.add(new Customer("Pranali", 25000, 1));
        customers.add(new Customer("Naman", 97000, 4));
        customers.add(new Customer("Tanmay", 18000, 1));
        customers.add(new Customer("Mandar", 125000, 5));
        customers.add(new Customer("Gauri", 84000, 3));
        return customers;
    }
}
