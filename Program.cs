using System;
using RideSharingInterview.Models;
using RideSharingInterview.Services;

namespace RideSharingInterview
{

  class Program
  {
    static void Main(string[] args)
    {
      var rider = new Rider("Julien", 1, "South Korea");
      var driver = new Driver("Maurice", 2, "Aston Martin Valkyrie", "Madagascar");

      var driverService = new DriverService();
      var riderService = new RiderService();
      var tripService = new TripService();

      string destination = riderService.RequestRide(rider, "South Pole");

      var trip = new Trip(rider, destination);

      driverService.AcceptRide(driver, trip);
      tripService.CompleteTrip(trip);
    }
  }
}