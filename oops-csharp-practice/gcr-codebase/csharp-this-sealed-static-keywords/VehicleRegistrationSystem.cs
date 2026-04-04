using System;

class Vehicle{
    static double RegistrationFee = 1000;

    private readonly string RegistrationNumber;
    private string OwnerName;
    private string VehicleType;

    public Vehicle(string regnumber,string ownername, string vehicletype){
        this.RegistrationNumber =regnumber;
        this.OwnerName = ownername;
        this.VehicleType =vehicletype;
    }

    public void DisplayVehicleDetails(){
        Console.WriteLine("Registration Number : "+ RegistrationNumber);
        Console.WriteLine("Owner Name : " +OwnerName);
        Console.WriteLine("Vehicle Type : " +VehicleType);
        Console.WriteLine("Registration Fee : " + RegistrationFee);
    }

    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }
}

class VehicleRegistrationSystem{
    static void Main(string[] args){
        Vehicle v1 = new Vehicle("UP2424235", "Animesh","Car");
        Vehicle v2 = new Vehicle("PW2o5837","NIhi","Bike");

        Vehicle.UpdateRegistrationFee(6500);

        if(v1 is Vehicle)
            Console.WriteLine("Yes its from Vehicle class");
        else
            Console.WriteLine("No its not from Vehicle class");

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}
