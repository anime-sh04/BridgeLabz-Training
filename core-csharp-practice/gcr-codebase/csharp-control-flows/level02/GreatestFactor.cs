using System;

class GreatestFactor{
	static void Main(string[] args){
		int n = Convert.ToInt32(Console.ReadLine());
		int greatest = 1;
		for(int i=1; i<=n/2; i++){
			if(n%i == 0 && i > greatest){
				greatest = i;
			}
		}
		Console.WriteLine("Greatest Factor : " + greatest);
	}
}
		