using System.Collections.Generic;

namespace tripsApp.Data
{
    public interface ITripService
    {
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void UpdateTrip(int tripId, Trip trip);
        void DeteleTrip(int tripId);
        void AddTrip(Trip trip);
    }
}