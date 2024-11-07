using RideSharingInterview.Models;

namespace RideSharingInterview.Interfaces
{
    public interface IDriverService
    {
        void AcceptRide(Driver driver, Trip trip);
        void CompleteRide(Driver driver);
    }
}
