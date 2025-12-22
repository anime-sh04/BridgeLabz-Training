using System;

class MultiplicationTable {
	static void Main(string[] args){
		
		int number = Convert.ToInt32(Console.ReadLine());
		if(number >=6 && number <=9){
			for(int i=1; i<=10;i++){
				Console.WriteLine(number +" * " + i + " = " + i*number);
			}
		}
		else{
			Console.WriteLine("Enter Number between 6 and 9 ");
		}
	}
}