
using RideSharingInterview.Interfaces;

namespace RideSharingInterview.Services
{
  public class NotificationService : INotificationService
  {
    public void NotifyUser(string message)
    {
      Console.WriteLine($"Notification: {message}");
    }
  }
}

