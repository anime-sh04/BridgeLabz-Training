using System;

class TotalPrice{
	static void Main(string[] args){
		double numOfStudents = Convert.ToDouble(Console.ReadLine());
		double total = (numOfStudents*(numOfStudents-1))/2;
		
		Console.WriteLine("The total number of Handshakes is " +total);
	}
}
