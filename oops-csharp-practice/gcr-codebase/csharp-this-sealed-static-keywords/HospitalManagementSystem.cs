using System;

class Hospital{
	public static string HospitalName = "GLA";
	private string Name;
	private int Age;
	private string Ailment;
	public readonly string PatientID;
	
	private static long totalPatients =0;
	public Hospital(string name,int age,string ailment,string patientid){
		this.Name = name;
		this.Age = age;
		this.Ailment=ailment;
		this.PatientID = patientid;
		totalPatients++;
	}
	
	public static void GetTotalPatients(){
		Console.WriteLine("Total Patients in hospital are : "+totalPatients);
	}
	
	public void DisplayPatients(){
		Console.WriteLine("Hospital Name : " + HospitalName);
		Console.WriteLine("Patient Name : " + Name);
		Console.WriteLine("Patient Age : " + Age);
		Console.WriteLine("Patient Ailment : " + Ailment);
		Console.WriteLine("Patient Id : " + PatientID);
	}
}
class HospitalManagementSystem{
	static void Main(string[] args){
		Hospital h1 = new Hospital("Animesh",21,"AWfawf","P1245");
		Hospital h2 = new Hospital("Anwing",20,"AWwrqwr","P1312");
		
		if(h1 is Hospital)
			Console.WriteLine("Yes it is a instance of Hospital");
		
		h1.DisplayPatients();
		h2.DisplayPatients();
		Hospital.GetTotalPatients();
	}
}
