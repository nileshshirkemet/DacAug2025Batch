using Microsoft.Data.SqlClient;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);
using var connection = new SqlConnection("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Trust Server Certificate=True");
connection.Open();
using var command = connection.CreateCommand();
command.Transaction = connection.BeginTransaction();
try
{
    command.CommandText = "UPDATE Counters SET CurrentValue=CurrentValue+1 WHERE Id='order'";
    command.ExecuteNonQuery();
    command.CommandText = "SELECT CurrentValue+SeedValue FROM Counters WHERE Id='order'";
    int orderNo = Convert.ToInt32(command.ExecuteScalar());
    command.CommandText = "INSERT INTO OrderDetail VALUES(@ordno, @orddt, @custid, @pno, @qty)"; //parameterized sql
    command.Parameters.AddWithValue("@ordno", orderNo);
    command.Parameters.AddWithValue("@orddt", DateTime.Today);
    command.Parameters.AddWithValue("@custid", customerId);
    command.Parameters.AddWithValue("@pno", productNo);
    command.Parameters.AddWithValue("@qty", quantity);
    command.ExecuteNonQuery();
    command.Transaction.Commit();
    Console.WriteLine("New Order Number: {0}", orderNo);
}
catch(Exception ex)
{
    command.Transaction.Rollback();
    Console.WriteLine("Order Failed: {0}", ex.Message);
}
