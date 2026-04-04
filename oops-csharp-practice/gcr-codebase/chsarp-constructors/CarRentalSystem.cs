using System;

class Car{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;

    public Car(){
        customerName = "Unknown";
        carModel = "Standard";
        rentalDays = 1;
    }

    public Car(string customerName, string carModel, int rentalDays){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    public void CalculateTotalCost(){
        double dailyRate = 1000;
        totalCost = dailyRate*rentalDays;
    }

    public void Display(){
        Console.WriteLine("Customer Name : " + customerName);
        Console.WriteLine("Car Model     : " + carModel);
        Console.WriteLine("Rental Days   : " + rentalDays);
        Console.WriteLine("Total Cost    : " + totalCost);
    }
}

class CarRentalSystem{
    static void Main(){
        Car r1 = new Car();
        Car r2 = new Car("Animesh", "SUV", 5);
		
		r1.CalculateTotalCost();
		r2.CalculateTotalCost();
        r1.Display();
        r2.Display();
    }
}
