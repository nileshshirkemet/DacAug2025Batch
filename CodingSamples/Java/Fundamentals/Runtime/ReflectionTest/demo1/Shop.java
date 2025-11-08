record Item(String name, String brand, int stock){}

record Customer(String id, double purchase, int rating){}

class Shop {

    public static Item popularItem() {
        return new Item("cpu", "intel", 150);
    }

    public static Customer bestCustomer() {
        return new Customer("Jack", 150000, 5);
    }
}
