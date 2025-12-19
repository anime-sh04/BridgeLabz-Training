using System;

class PensLeft{
	static void Main(string[] args){
		int pens = 14;
		int students = 3;
		int pensDivided = pens/students;
		int pensLeft = pens%students;
		
		Console.WriteLine("The Pen Per Student is "+ pensDivided+ " and the remaining pen not distributed is "+ pensLeft);
	}
}
