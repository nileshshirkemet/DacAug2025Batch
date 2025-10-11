using Taxation;

class Auditor : IDisposable
{
    public Auditor()
    {
        Console.WriteLine("Auditor Log [{0}] - starting audit session", DateTime.Now);
    }

    public void Audit(string id, ITaxPayer employee)
    {
        Console.WriteLine("Auditing {0}...", id);
        if(id.Length < 4)
            throw new ArgumentException("Invalid ID");
        decimal payment = employee.IncomeTax() + 500;
        Console.WriteLine("Total tax payment: {0:0.00}", payment);
    }

    public void Dispose()
    {
        Console.WriteLine("Auditor Log [{0}] - ending audit session", DateTime.Now);
    }
}