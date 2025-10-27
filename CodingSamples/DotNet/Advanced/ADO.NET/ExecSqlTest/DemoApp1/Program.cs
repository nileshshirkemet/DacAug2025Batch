using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=shop.db");
connection.Open();
using var command = connection.CreateCommand();
if(args.Length == 0)
{
    command.CommandText = "SELECT UserName, Address, Credit FROM CustomerInfo";
    using var reader = command.ExecuteReader();
    while(reader.Read())
        Console.WriteLine("{0}\t{1}\t{2}", reader.GetString(0), reader.GetString(1), reader.GetDecimal(2));
}
else if(args[0].Length == 5)
{
    command.CommandText = $"UPDATE CustomerInfo SET Credit=Credit+100 WHERE UserName='{args[0]}'";
    int n = command.ExecuteNonQuery();
    if(n == 0)
        Console.WriteLine("No such customer!");
}
