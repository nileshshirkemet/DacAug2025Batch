namespace Sales;

public static class ProductSupport
{
    public static decimal GetTotalSales(this Product item)
    {
        return item.Orders
            .Select(e => e.Quantity)
            .Sum() * item.Price;
    }
}
