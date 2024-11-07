namespace RideSharingInterview.Models
{
  public class Rider : User
  {
    public string CurrentLocation { get; set; }

    public Rider(string name, int userId, string currentLocation) : base(name, userId)
    {
      CurrentLocation = currentLocation;
    }

    public string RequestRide(string destination)
    {
      Console.WriteLine($"{Name} is requesting a ride to {destination}.");
      return destination;
    }
  }
}