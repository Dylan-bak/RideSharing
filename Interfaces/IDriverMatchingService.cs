using RideSharingInterview.Models;

namespace RideSharingInterview.Interfaces
{
  public interface IDriverMatchingService
  {
    Driver? FindClosestDriver(Rider rider, Driver[] drivers);
  }
}