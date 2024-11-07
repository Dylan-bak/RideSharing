using System;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class TripService
  {

    public void CompleteTrip(Trip trip)
    {
      if (trip.Driver != null)
      {
        var driverService = new DriverService();

        Console.WriteLine($"Trip completed by driver {trip.Driver.Name} for rider {trip.Rider.Name}.");
        driverService.CompleteRide(trip.Driver);
      }
      else
      {
        Console.WriteLine("No driver assigned for this trip.");
      }
    }
  }
}
