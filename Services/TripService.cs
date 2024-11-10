using System;
using RideSharingInterview.Interfaces;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class TripService : ITripService
  {
    private readonly IDriverService DriverService;
    private readonly IDriverMatchingService DriverMatchingService;
    private readonly INotificationService NotificationService;


    public TripService(IDriverService driverService, IDriverMatchingService driverMatchingService, INotificationService notificationService)
    {
      DriverService = driverService;
      DriverMatchingService = driverMatchingService;
      NotificationService = notificationService;
    }

    public void OpenTrip(Trip trip, Driver[] drivers)
    {
      Driver? driver = DriverMatchingService.FindClosestDriver(trip.Rider, drivers);
      if (driver != null)
      {
        DriverService.AcceptRide(driver, trip);
        NotificationService.NotifyUser($"Driver '{driver.Name}' is most closest. '{driver.Name}' gonna pick you up.");
      }
      else
      {
        NotificationService.NotifyUser("No Driver available at the moment.");
      }
    }

    public void CompleteTrip(Trip trip)
    {
      if (trip.Driver != null)
      {
        Console.WriteLine($"Trip completed by driver {trip.Driver.Name} for rider {trip.Rider.Name}.");
        DriverService.CompleteRide(trip.Driver);
      }
      else
      {
        Console.WriteLine("No driver assigned for this trip.");
      }
    }
  }
}
