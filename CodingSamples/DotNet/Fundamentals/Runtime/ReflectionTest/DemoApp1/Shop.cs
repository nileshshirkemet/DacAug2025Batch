namespace DemoApp;

record Item(string Name, string Brand, int Stock = 125);

readonly record struct Customer(string Id, decimal Purchase, int Rating);

class Shop
{
    public static Item GetPopularItem()
    {
        return new Item("cpu", "intel");
    }

    public static Customer GetBestCustomer()
    {
        return new Customer("Jack", 150000, 5);
    }
}
