namespace RideSharingInterview.Models
{
  public class Rider : User
  {
    public string CurrentLocation { get; set; }

    public Rider(string name, int userId, string currentLocation) : base(name, userId)
    {
      CurrentLocation = currentLocation;
    }
  }
}