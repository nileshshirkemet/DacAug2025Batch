namespace DemoApp;

record Item(string Name, string Brand);

//a value type record is mutable(modifiable) by default unless
//it is defined with readonly keyword
readonly record struct Customer(string Id, decimal Purchase, int Rating);

class Shop
{
    public static Item[] GetItems()
    {
        return new Item[]
        {
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

    public static ICollection<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer("Anshul", 45000, 3),
            new Customer("Jayesh", 68000, 4),
            new Customer("Faizan", 39000, 2),
            new Customer("Rehan", 52000, 3),
            new Customer("Eshan", 78000, 5),
            new Customer("Pranali", 25000, 1),
            new Customer("Naman", 97000, 4),
            new Customer("Tanmay", 18000, 1),
            new Customer("Mandar", 125000, 5),
            new Customer("Gauri", 84000, 3)
        };
    }
}
