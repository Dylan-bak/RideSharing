using System;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class DriverService
  {
    public void AcceptRide(Driver driver, Trip trip)
    {
      driver.Available = false;
      Console.WriteLine($"{driver.Name} accepted the ride to {trip.Destination}.");
      trip.AssignDriver(driver);
    }

    public void CompleteRide(Driver driver)
    {
      driver.Available = true;
      Console.WriteLine($"{driver.Name} has completed the ride.");
    }
  }
}
