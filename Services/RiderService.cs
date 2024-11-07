using System;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class RiderService
  {
    public string RequestRide(Rider rider, string destination)
    {
      Console.WriteLine($"{rider.Name} is requesting a ride to {destination}.");
      return destination;
    }
  }
}
