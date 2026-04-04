using System;

namespace RideHailingSystem
{
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId { get { return vehicleId; } }
        public string DriverName { get { return driverName; } }
        public double RatePerKm { get { return ratePerKm; } }

        public Vehicle(int id, string driver, double rate)
        {
            vehicleId = id;
            driverName = driver;
            ratePerKm = rate;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("\nVehicle ID : " + VehicleId);
            Console.WriteLine("Driver : " + DriverName);
            Console.WriteLine("Rate/Km : " + RatePerKm);
        }
    }

    class Car : Vehicle,IGPS
    {
        private string location = "Unknown";

        public Car(int id, string driver, double rate):base(id, driver, rate) { }

        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance;
        }

        public string GetCurrentLocation()
        {
            return location;
        }

        public void UpdateLocation(string newLocation)
        {
            location = newLocation;
        }
    }

    class Bike : Vehicle,IGPS
    {
        private string location = "Unknown";

        public Bike(int id, string driver, double rate): base(id, driver, rate) { }

        public override double CalculateFare(double distance)
        {
            return (RatePerKm * distance) * 0.8;
        }

        public string GetCurrentLocation()
        {
            return location;
        }

        public void UpdateLocation(string newLocation)
        {
            location = newLocation;
        }
    }

    class Auto : Vehicle, IGPS
    {
        private string location = "Unknown";

        public Auto(int id, string driver, double rate)
            : base(id, driver, rate) { }

        public override double CalculateFare(double distance)
        {
            return (RatePerKm * distance) + 20;
        }

        public string GetCurrentLocation()
        {
            return location;
        }

        public void UpdateLocation(string newLocation)
        {
            location = newLocation;
        }
    }

    class Program
    {
        static void ProcessRides(Vehicle[] vehicles, double distance)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle v = vehicles[i];

                v.GetVehicleDetails();
                Console.WriteLine("Fare for " + distance + " km : " +v.CalculateFare(distance));

                if (v is IGPS)
                {
                    IGPS gps = (IGPS)v;
                    gps.UpdateLocation("City Center");
                    Console.WriteLine("Current Location : " +gps.GetCurrentLocation());
                }
            }
        }

        static void Main()
        {
            Vehicle[] fleet = new Vehicle[3];

            fleet[0] = new Car(1,"Animesh", 15);
            fleet[1] = new Bike(2,"Rahul", 10);
            fleet[2] = new Auto(3, "Ramesh", 12);

            ProcessRides(fleet, 10);
        }
    }
}
