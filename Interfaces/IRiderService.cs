using RideSharingInterview.Models;

namespace RideSharingInterview.Interfaces
{
    public interface IRiderService
    {
        string RequestRide(Rider rider, string destination);
    }
}
