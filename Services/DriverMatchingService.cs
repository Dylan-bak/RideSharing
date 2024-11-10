
using RideSharingInterview.Interfaces;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class DriverMatchingService : IDriverMatchingService
  {
    public Driver? FindClosestDriver(Rider rider, Driver[] drivers)
    {
      var minDistance = double.MaxValue;
      Driver? closestDriver = null;
      foreach (Driver driver in drivers)
      {
        if (!driver.Available) continue;

        var xDistance = rider.Coordinates.X - driver.Coordinates.X;
        var yDistance = rider.Coordinates.Y - driver.Coordinates.Y;
        var distance = Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        
        if(distance < minDistance) 
        {
          minDistance = distance;
          closestDriver = driver;
        }
      }
      return closestDriver;
    }
  }
}

