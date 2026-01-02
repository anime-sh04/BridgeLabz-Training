using System;

class Course{
	private string courseName;
	private string duration;
	private double fee;
	
	static string instituteName = "GLA";
	
	public Course(string courseName, string duration,double fee){
		this.courseName = courseName;
		this.duration = duration;
		this.fee = fee;
	}
	
	public void DisplayCourseDetails(){
		Console.WriteLine("Institute Name : " + instituteName);
		Console.WriteLine("Course Name : " + courseName);
		Console.WriteLine("Course Duration : " + duration);
		Console.WriteLine("Course Fee : " + fee);
	}
	public static void UpdateInsituteName(string newinstituteName){
		instituteName = newinstituteName;
	}
}

class OnlineCourseManagement{
	static void Main(string[] args){
		Course c1 = new Course("C#","3 month",2000);
		Course c2 = new Course("Java","1 month",5000);
		
		c1.DisplayCourseDetails();
		c2.DisplayCourseDetails();
		
		Course.UpdateInsituteName("GL Bajaj");
		
		
		c1.DisplayCourseDetails();
		c2.DisplayCourseDetails();
	}
}