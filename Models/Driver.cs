namespace RideSharingInterview.Models
{
  public class Driver : User
  {
    public string CarModel { get; set; }
    public string Location { get; set; }
    public bool Available { get; set; } = true;

    public Driver(string name, int userId, string carModel, string location) : base(name, userId)
    {
      CarModel = carModel;
    }

    public void AcceptRide(Trip trip)
    {
      Available = false;
      Console.WriteLine($"{Name} accepted the ride to {trip.Destination}.");
      trip.AssignDriver(this);
    }

    public void CompleteRide()
    {
      Available = true;
      Console.WriteLine($"{Name} has completed the ride.");
    }

  }
}