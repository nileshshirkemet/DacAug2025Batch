namespace DemoApp.Tourism.Data;

public class Traveller
{
    //persistent property
    public string Id { get; set; }

    //persistent property
    public int Rating { get; set; }

    //navigation property (one-to-many relationship)
    public List<Trip> Trips { get; set; } =[];
}