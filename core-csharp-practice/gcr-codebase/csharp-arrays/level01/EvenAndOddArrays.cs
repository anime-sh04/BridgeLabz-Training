using System;

class EvenAndOddArrays{
	static void Main(string[] args){
		
		int number = int.Parse(Console.ReadLine());
		
		int size = (number/2) +1;
		int[] arrEven = new int[size];
		int[] arrOdd = new int[size];
		int c =1 , l =1;
		for(int i=1;i<=number;i++){
			if(i%2 == 0){
				arrEven[l-1] = i;
				l++;
			}
			else{
				arrOdd[c-1] = i;
				c++;
			}
		}
		
		Console.WriteLine("Even Array : ");
		for(int j=0;j<arrEven.Length;j++){
			Console.WriteLine(arrEven[j]);
		}
		
		Console.WriteLine("Odd Array : ");
		for(int k=0;k<arrOdd.Length;k++){
			Console.WriteLine(arrOdd[k]);
		}
	}
}
			