using System;

class Vehicle{
	private string ownerName;
	private string vehicleType;
	
	static int registrationFee = 2000;
	
	public Vehicle(string ownerName,string vehicleType){
		this.ownerName = ownerName;
		this.vehicleType = vehicleType;
	}
	
	public void DisplayVehicleDetails(){
		Console.WriteLine("Registration Fees : " + registrationFee);
		Console.WriteLine("Owner Name : " + ownerName);
		Console.WriteLine("Vehicle Type : " + vehicleType);
	}
	
	public static void UpdateRegistrationFee(int newregistrationFee){
		registrationFee = newregistrationFee;
	}
}
class VehicleRegistration{
	static void Main(string[] args){
		Vehicle v1 = new Vehicle("Animesh","Offroad");
		Vehicle v2 = new Vehicle("Anwtfa","Nwra");
		
		v1.DisplayVehicleDetails();
		v2.DisplayVehicleDetails();
		
		Vehicle.UpdateRegistrationFee(3000);
		
		v1.DisplayVehicleDetails();
		v2.DisplayVehicleDetails();
	}
}