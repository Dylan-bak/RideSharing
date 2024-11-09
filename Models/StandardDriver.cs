namespace RideSharingInterview.Models
{
  public class StandardDriver : Driver
  {
    public StandardDriver(string name, int userId, string carModel, string location, Coordinates coordinates) : base(name, userId, carModel, location, coordinates) { }
  }
}