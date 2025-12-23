using System;

class FizzBuzz{
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		
		string[] arr = new string[number];
		
		if(number>0){
			for(int i=1;i<=number;i++){
				if(i%3 == 0 && i%5 == 0){
					arr[i-1] = "FizzBuzz";
				}
				else if(i%3 == 0){
					arr[i-1] = "Fizz";
				}
				else if(i%5 == 0){
					arr[i-1] = "Buzz";
				}
				else{
					arr[i-1] = i.ToString();
				}
			}
		}
		for(int i=0;i<number;i++){
			Console.WriteLine("Position "+(i+1)+" = " + arr[i]);
		}
	}
}