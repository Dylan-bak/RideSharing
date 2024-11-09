namespace RideSharingInterview.Models
{
  public class User
  {
    public string Name { get; set; }
    public int UserId { get; set; }
    public Coordinates Coordinates { get; set; }

    public User(string name, int userId, Coordinates coordinates)
    {
      Name = name;
      UserId = userId;
      Coordinates = coordinates;
    }

    public override string ToString()
    {
      return $"User(Name={Name}, UserId={UserId}, Coordinates=({Coordinates.X}, {Coordinates.Y}))";
    }
  }
}
