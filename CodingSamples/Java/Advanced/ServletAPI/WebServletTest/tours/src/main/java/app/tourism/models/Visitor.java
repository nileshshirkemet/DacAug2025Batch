package app.tourism.models;

import java.util.Date;

import app.tourism.data.TravelerEntity;
import app.tourism.data.TripEntity;

public record Visitor(String name, String stars, int visits, Date recent) {
    
    public static Visitor fromTraveler(TravelerEntity traveler) {
        var trips = traveler.getTours();
        var last = trips.stream()
            .map(TripEntity::getCheckin)
            .max(Date::compareTo);
        return new Visitor(
            traveler.getId(), 
            "*".repeat(traveler.getRating()), 
            trips.size(), 
            last.get()
        );
    }
}
