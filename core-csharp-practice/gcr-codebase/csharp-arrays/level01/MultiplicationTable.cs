using System;

class MultiplicationTable{
	static void Main(string[] args){
		
		int[] arr = new int[10];
		
		int number = int.Parse(Console.ReadLine());
		
		for(int i=0;i<10;i++){
			arr[i] = number * (i+1);
		}
		
		for(int i=0;i<10;i++){
			Console.WriteLine(number+" * "+(i+1)+" = "+ arr[i]);
		}
	}
}