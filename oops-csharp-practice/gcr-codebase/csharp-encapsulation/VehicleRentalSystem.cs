using System;

namespace VehicleRentalSystem
{
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        protected string insurancePolicyNumber;

        public string VehicleNumber { get { return vehicleNumber; } }
        public string Type { get { return type; } }
        public double RentalRate { get { return rentalRate; } }

        public Vehicle(string number, string type, double rate, string policy)
        {
            vehicleNumber = number;
            this.type = type;
            rentalRate = rate;
            insurancePolicyNumber = policy;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayBasicDetails()
        {
            Console.WriteLine("\nVehicle Number : " + VehicleNumber);
            Console.WriteLine("Type : " + Type);
            Console.WriteLine("Rental Rate : " + RentalRate + " per day");
        }
    }

    class Car : Vehicle, IInsurable
    {
        public Car(string num, double rate, string policy)
            : base(num, "Car", rate, policy) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.10;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance (Policy: " + insurancePolicyNumber + ")";
        }
    }

    class Bike : Vehicle, IInsurable
    {
        public Bike(string num, double rate, string policy)
            : base(num, "Bike", rate, policy) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.05;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance (Policy: " + insurancePolicyNumber + ")";
        }
    }

    class Truck : Vehicle, IInsurable
    {
        public Truck(string num, double rate, string policy)
            : base(num, "Truck", rate, policy) { }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) + 1000;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.15;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance -Policy: " + insurancePolicyNumber;
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car("CARwfw3", 2000, "C-af90");
            vehicles[1] = new Bike("BIKEawtwag", 500, "Bawg");
            vehicles[2] = new Truck("TRKawwrt32", 5000, "T-awfg");

            int days =5;

            for (int i = 0; i<vehicles.Length; i++)
            {
                Vehicle v = vehicles[i];
                v.DisplayBasicDetails();

                double rental = v.CalculateRentalCost(days);

                double insurance = 0;
                string insuranceInfo = "No Insurance";

                if (v is IInsurable)
                {
                    IInsurable ins = (IInsurable)v;
                    insurance = ins.CalculateInsurance();
                    insuranceInfo = ins.GetInsuranceDetails();
                }

                Console.WriteLine("Rental Cost for " + days + " days : " + rental);
                Console.WriteLine("Insurance Cost : " + insurance);
                Console.WriteLine("Insurance Details : " + insuranceInfo);
            }

            Console.ReadLine();
        }
    }
}
