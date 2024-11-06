using System;

namespace RideSharingInterview
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

    public class Driver : User
    {
        public string CarModel { get; set; }
        public string Location { get; set; }
        public bool Available { get; set; } = true;

        public Driver(string name, int userId, string carModel, string location) : base(name, userId)
        {
            CarModel = carModel;
            Location = location;
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

    public class Trip
    {
        public Rider Rider { get; set; }
        public string Destination { get; set; }
        public Driver Driver { get; private set; }

        public Trip(Rider rider, string destination)
        {
            Rider = rider;
            Destination = destination;
        }

        public void AssignDriver(Driver driver)
        {
            Driver = driver;
            Console.WriteLine($"Trip assigned to driver {driver.Name}.");
        }

        public void CompleteTrip()
        {
            if (Driver != null)
            {
                Console.WriteLine($"Trip completed by driver {Driver.Name} for rider {Rider.Name}.");
                Driver.CompleteRide();
            }
            else
            {
                Console.WriteLine("No driver assigned for this trip.");
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var rider = new Rider("Julien", 1, "South Korea");
            var driver = new Driver("Maurice", 2, "Aston Martin Valkyrie", "Madagascar");

            string destination = rider.RequestRide("South Pole");

            var trip = new Trip(rider, destination);

            driver.AcceptRide(trip);

            trip.CompleteTrip();

        }

    }

}