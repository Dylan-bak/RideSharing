using System;
using RideSharingInterview.Interfaces;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class TripService : ITripService
  {
    private readonly IDriverService driverService;
    private readonly IDriverMatchingService driverMatchingService;
    private readonly INotificationService notificationService;


    public TripService(IDriverService driverService, IDriverMatchingService driverMatchingService, INotificationService notificationService)
    {
      this.driverService = driverService;
      this.driverMatchingService = driverMatchingService;
      this.notificationService = notificationService;
    }

    public void OpenTrip(Trip trip, Driver[] drivers)
    {
      Driver? driver = this.driverMatchingService.FindClosestDriver(trip.Rider, drivers);
      if (driver != null)
      {
        this.driverService.AcceptRide(driver, trip);
        this.notificationService.NotifyUser($"Driver '{driver.Name}' is most closest. '{driver.Name}' gonna pick you up.");
      }
      else
      {
        this.notificationService.NotifyUser("No Driver available at the moment.");
      }
    }

    public void CompleteTrip(Trip trip)
    {
      if (trip.Driver != null)
      {
        Console.WriteLine($"Trip completed by driver {trip.Driver.Name} for rider {trip.Rider.Name}.");
        this.driverService.CompleteRide(trip.Driver);
      }
      else
      {
        Console.WriteLine("No driver assigned for this trip.");
      }
    }
  }
}
