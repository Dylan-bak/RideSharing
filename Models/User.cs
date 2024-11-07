namespace RideSharingInterview.Models
{
  public class User
  {
    public string Name { get; set; }
    public int UserId { get; set; }

    public User(string name, int userId)
    {
      Name = name;
      UserId = userId;
    }

    public override string ToString()
    {
      return $"User(Name={Name}, UserId={UserId})";
    }
  }
}
