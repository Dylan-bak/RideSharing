namespace RideSharingInterview.Models
{
  public class Driver : User
  {
    public string CarModel { get; set; }
    public string Location { get; set; }
    public bool Available { get; set; } = true;

    public Driver(string name, int userId, string carModel, string location, Coordinates coordinates) : base(name, userId, coordinates)
    {
      CarModel = carModel;
      Location = location;
    }
  }
}