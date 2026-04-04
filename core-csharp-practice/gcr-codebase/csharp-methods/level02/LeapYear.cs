using System;

class LeapYear{
	public static string Leap(int year){
		if(year<1582){
			return "Year must be > 1582";
		}
		if(year%4 ==0){
			return "Leap Year";
		}
		else{
			return "Not A Leap Year";
		}
	}
	
	static void Main(string[] args){
		int year = int.Parse(Console.ReadLine());
		Console.WriteLine(Leap(year));
	}
}