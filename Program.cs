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

      var rider = new Rider("Julien", 1, "South Korea");
      var driver = new Driver("Maurice", 2, "Aston Martin Valkyrie", "Madagascar");

      string destination = riderService.RequestRide(rider, "South Pole");
      var trip = new Trip(rider, destination);
      
      driverService.AcceptRide(driver, trip);
      tripService.CompleteTrip(trip);
    }
  }
}