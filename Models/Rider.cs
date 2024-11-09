namespace RideSharingInterview.Models
{
  public class Rider : User
  {
    public string CurrentLocation { get; set; }

    public Rider(string name, int userId, string currentLocation, Coordinates coordinates) : base(name, userId, coordinates)
    {
      CurrentLocation = currentLocation;
    }
  }
}