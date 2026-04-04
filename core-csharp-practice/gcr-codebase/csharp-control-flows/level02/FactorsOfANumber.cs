using System;

class FactorsOfANumber{
	static void Main(string[] args){
		int n = Convert.ToInt32(Console.ReadLine());
		
		for(int i =1;i<n/2;i++){
			if(n%i == 0){
				Console.Write(i+",");
			}
		}
		Console.Write(n);
	}
}
