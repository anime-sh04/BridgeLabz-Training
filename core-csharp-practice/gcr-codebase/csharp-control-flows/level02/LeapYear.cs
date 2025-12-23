using System;

class LeapYear{
	static void Main(string[] args){
		int year = Convert.ToInt32(Console.ReadLine());
		
		if(year % 4 == 0){
			Console.WriteLine("It is a Leap Year");
		}
		else if(year < 1582){
			Console.WriteLine("Provide a year > 1581");
		}
		else{
			Console.WriteLine("It is Not an Leap Year");
		}
	}
}
