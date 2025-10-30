using DemoApp.Tourism.Data;

namespace DemoApp.Tourism.Models;

public class SiteModel
{
    public IEnumerable<Visitor> GetVisitors()
    {
        using var site = new SiteDbContext();
        var selection = from t in site.Travellers
            where t.Id.Length > 3
            select new Visitor 
            {
                Name = t.Id,
                Stars = new string('*', t.Rating),
                Visits = t.Trips.Count,
                Recent = t.Trips.Max(x => x.Checkin)
            };
        return selection.ToList();
    }

    public void HandleVisit(string visitorName, int visitorRating)
    {
        using var site = new SiteDbContext();
        var traveller = site.Travellers.Find(visitorName);
        if(traveller is null)
        {
            traveller = new Traveller { Id = visitorName };
            site.Travellers.Add(traveller);
        }
        traveller.Trips.Add(new Trip());
        traveller.Rating = visitorRating;
        site.SaveChanges();
    }
}