using RideSharingInterview.Interfaces;
using RideSharingInterview.Models;
using RideSharingInterview.Services;

namespace RideSharingInterview
{
  class Program
  {
    static void Main(string[] args)
    {
      DriverService driverService = new DriverService();
      RiderService riderService = new RiderService();

      DriverMatchingService driverMatchingService = new DriverMatchingService();
      NotificationService notificationService = new NotificationService();
      TripService tripService = new TripService(driverService, driverMatchingService, notificationService);

      Rider rider = new Rider("Julien", 1, "South Korea", new Coordinates(127.13, 37.53));
      Driver[] drivers = new Driver[]
      {
        new StandardDriver("Maurice", 2, "Aston Martin Valkyrie", "Madagascar", new Coordinates(47.50, 18.87)),
        new PremiumDriver("Steven", 3, "SM5", "Singapore", new Coordinates(103.81, 1.35))
      };

      string destination = riderService.RequestRide(rider, "South Pole");
      Trip trip = new Trip(rider, destination);
      Driver? closetDriver = tripService.OpenTrip(trip, drivers);
      if (closetDriver == null) throw new InvalidOperationException("No Driver available at the moment.");
      driverService.AcceptRide(closetDriver, trip);
      tripService.CompleteTrip(trip);

      /* 
      string destination = riderService.RequestRide(rider, "South Pole");
      Trip trip = new Trip(rider, destination);
      tripService.OpenTrip(trip, drivers);
      tripService.CompleteTrip(trip);
      */ 
    }
  }
}