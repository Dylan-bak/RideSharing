using RideSharingInterview.Models;

namespace RideSharingInterview.Interfaces
{
    public interface ITripService
    {
        void OpenTrip(Trip trip, Driver[] drivers);
        void CompleteTrip(Trip trip);
    }
}
