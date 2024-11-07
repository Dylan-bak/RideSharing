using System;
using RideSharingInterview.Models;

namespace RideSharingInterview
{
  public class Trip
  {
    public Rider Rider { get; set; }
    public string Destination { get; set; }
    public Driver Driver { get; private set; }

    public Trip(Rider rider, string destination)
    {
      Rider = rider;
      Destination = destination;
    }

    public void AssignDriver(Driver driver)
    {
      Driver = driver;
      Console.WriteLine($"Trip assigned to driver {driver.Name}.");
    }

    public void CompleteTrip()
    {
      if (Driver != null)
      {
        Console.WriteLine($"Trip completed by driver {Driver.Name} for rider {Rider.Name}.");
        Driver.CompleteRide();
      }
      else
      {
        Console.WriteLine("No driver assigned for this trip.");
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var rider = new Rider("Julien", 1, "South Korea");
      var driver = new Driver("Maurice", 2, "Aston Martin Valkyrie", "Madagascar");

      string destination = rider.RequestRide("South Pole");

      var trip = new Trip(rider, destination);

      driver.AcceptRide(trip);

      trip.CompleteTrip();

    }

  }

}