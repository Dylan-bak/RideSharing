namespace RideSharingInterview.Models
{
  public class PremiumDriver : Driver
  {
    public PremiumDriver(string name, int userId, string carModel, string location, Coordinates coordinates) : base(name, userId, carModel, location, coordinates) { }
  }
}