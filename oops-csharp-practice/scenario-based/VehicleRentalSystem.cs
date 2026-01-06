using System;

namespace VehicleRentalSystem
{
    interface IRentable
    {
        double CalculateRent(int days);
    }

    class Vehicle:IRentable
    {
        protected string vehicleNumber;
        protected double ratePerDay;

        public Vehicle(string number, double rate)
        {
            vehicleNumber =number;
            ratePerDay =rate;
        }

        public virtual double CalculateRent(int days)
        {
            return ratePerDay *days;
        }

        public virtual void Display()
        {
            Console.WriteLine("Vehicle Number: " +vehicleNumber);
            Console.WriteLine("Rate per day: " +ratePerDay);
        }
    }
    class Bike : Vehicle
    {
        public Bike(string number, double rate): base(number, rate) { }

        public override void Display()
        {
            Console.WriteLine("Bike Details");
            base.Display();
        }
    }

    class Car : Vehicle
    {
        public Car(string number, double rate) :base(number, rate) { }

        public override void Display()
        {
            Console.WriteLine("Car Details");
            base.Display();
        }
    }

    class Truck : Vehicle
    {
        public Truck(string number, double rate) :base(number, rate) { }

        public override void Display()
        {
            Console.WriteLine("Truck Details");
            base.Display();
        }
    }
	
    class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.name = name;
        }

        public void RentVehicle(Vehicle v,int days)
        {
            Console.WriteLine("Customer: "+ name);
            v.Display();
            double bill = v.CalculateRent(days);
            Console.WriteLine("Rental Days: " +days);
            Console.WriteLine("Total Rent: "+ bill);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Animesh");

            Vehicle b1 = new Bike("BIKE-101", 300);
            Vehicle c2 = new Car("CAR-202", 1000);
            Vehicle t1 = new Truck("TRUCK-303", 2000);

            c1.RentVehicle(b1, 3);
            c1.RentVehicle(c2, 2);
            c1.RentVehicle(t1, 4);
        }
    }
}
