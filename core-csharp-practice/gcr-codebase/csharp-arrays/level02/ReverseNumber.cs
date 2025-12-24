using System;

class ReverseNumber{
	static void Main(string[] args){
		
		int number = int.Parse(Console.ReadLine());
		int count = 0;
		int i = number;
		while(i!=0){
			count++;
			i = i/10;
		}
		i = number;
		int[] arr = new int[count];
		int index =0;
		while(i!=0){
			int d = i%10;
			arr[index] = d;
			i=i/10;
			index++;
		}
		Console.Write("Reverse Array = ");
		for(int j =0;j<arr.Length;j++){
			Console.Write(arr[j] + " ");
		}
	}
}
