using System;

class Student{
	public long rollNumber;
	protected string name;
	private double CGPA;
	
	public Student(long rollnumber,string name,double cgpa){
		this.rollNumber = rollnumber;
		this.name = name;
		this.CGPA = cgpa;
	}
	
	public void UpdateCgpa(double newCgpa){
		CGPA = newCgpa;
	}
	public void AccessCgpa(){
		Console.WriteLine("CGPA : " + CGPA);
	}
}
class PostgraduateStudent : Student{
	
    public PostgraduateStudent(long roll, string name, double cgpa)
        : base(roll, name, cgpa){ }

    public void DisplayPostgraduateDetails(){
        Console.WriteLine("Roll Number : " + rollNumber); 
        Console.WriteLine("Name : " + name);   // protected
        AccessCgpa();
    }
}

class UniversityManagementSystem{
    static void Main(string[] args){
        PostgraduateStudent s1 = new PostgraduateStudent(101, "Animesh",8.4);

        s1.DisplayPostgraduateDetails();

        s1.UpdateCgpa(9.1);
		
        s1.DisplayPostgraduateDetails();
    }
}