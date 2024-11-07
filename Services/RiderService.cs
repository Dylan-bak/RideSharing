using System;
using RideSharingInterview.Interfaces;
using RideSharingInterview.Models;

namespace RideSharingInterview.Services
{
  public class RiderService : IRiderService
  {
    public string RequestRide(Rider rider, string destination)
    {
      Console.WriteLine($"{rider.Name} is requesting a ride to {destination}.");
      return destination;
    }
  }
}
