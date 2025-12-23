using System;

class MultiplicationTable{
	static void Main(string[] args){
		
		int[] arr = new int[4];
		
		int number = int.Parse(Console.ReadLine());
		
		for(int i=0;i<4;i++){
			arr[i] = number * (i+6);
		}
		
		for(int i=0;i<4;i++){
			Console.WriteLine(number+" * "+(i+6)+" = "+ arr[i]);
		}
	}
}