using System.Data;
using Microsoft.Data.SqlClient;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);
using var connection = new SqlConnection("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False");
connection.Open();
using var command = connection.CreateCommand();
command.CommandText = "PlaceOrder";
command.CommandType = CommandType.StoredProcedure;
command.Parameters.AddWithValue("@Customer", customerId);
command.Parameters.AddWithValue("@Product", productNo);
command.Parameters.AddWithValue("@Quantity", quantity);
var orderNoParam = command.Parameters.Add("@orderId", SqlDbType.Int);
orderNoParam.Direction = ParameterDirection.Output;
try
{
    decimal payment = Convert.ToDecimal(command.ExecuteScalar());
    Console.WriteLine("New Order Number: {0}", orderNoParam.Value);
    Console.WriteLine("Total Payment: {0:0.00}", payment);
}
catch(Exception)
{
    Console.WriteLine("Cannot place the specified order!");
}
