using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Shopping.Data;

[Table("OrderDetail")]
public class Order
{
    [Column("OrderNo")]
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public string CustomerId { get; set; }

    public int ProductNo { get; set; }

    public int Quantity { get; set; }
}