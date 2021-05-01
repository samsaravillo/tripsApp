using System.Collections.Generic;
using System.Linq;

namespace tripsApp.Data
{
    public class TripService : ITripService
    {
        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }

        public void DeteleTrip(int tripId)
        {
            throw new System.NotImplementedException();
        }

        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if (oldTrip != null)
            {
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = trip.DateStarted;
                oldTrip.DateCompleted = trip.DateCompleted;
            }
        }
    }
}