using System;

class Vehicle{
    public string Model;
    public int MaxSpeed;

    public Vehicle(string model,int maxSpeed){
        Model = model;
        MaxSpeed =maxSpeed;
    }

    public void ShowVehicle(){
        Console.WriteLine("Model: " +Model);
        Console.WriteLine("Max Speed:"+ MaxSpeed);
    }
}

interface IRefuelable{
    void Refuel();
}

class ElectricVehicle : Vehicle{
    public ElectricVehicle(string model,int maxSpeed) :base(model,maxSpeed){}

    public void Charge(){
        Console.WriteLine("Charging electric vehicle");
    }
}

class PetrolVehicle : Vehicle, IRefuelable{
    public PetrolVehicle(string model,int maxSpeed) :base(model,maxSpeed){}

    public void Refuel(){
        Console.WriteLine("Refueling petrol vehicle");
    }
}

class VehicleManagementSystem{
    static void Main(string[] args){
        ElectricVehicle e = new ElectricVehicle("Tesla",250);
        PetrolVehicle p = new PetrolVehicle("Honda City",180);

        Console.WriteLine("Electric Vehicle");
        e.ShowVehicle();
        e.Charge();

        Console.WriteLine();

        Console.WriteLine("Petrol Vehicle");
        p.ShowVehicle();
        p.Refuel();
    }
}
