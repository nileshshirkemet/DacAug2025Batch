namespace DemoApp.Tourism.Data;

public class Trip
{
    //persistent property
    public int Id { get; set; }

    //persistent property
    public DateTime Checkin { get; set; } = DateTime.Now;

    //navigation property (many-to-one relationship)
    public Traveller Traveller { get; set; }
}