using System;

class NumberGuessing{
	static Random rnd = new Random();
	
	public static int generate(int s,int e){
		int c =rnd.Next(s,e);
		return c;
	}
	
	public static int feedback(){
		Console.WriteLine("1, Higher");
		Console.WriteLine("2, Lower");
		Console.WriteLine("3, Correct");
		
		int n = int.Parse(Console.ReadLine());
		
		switch(n){
			case 1:
				return 1;
			case 2:
				return 2;
			case 3:
				return -1;
			default:
				Console.WriteLine("Enter A valid Choice");
				return 0;
		}
			
	}
	
	static void Main(string[] args){
		int lowest =1;
		int higest = 100;
		bool f = true;
		while(f){
			int guess = generate(lowest,higest);
			Console.WriteLine("You are thinking of : " + guess);
			int p = feedback();
			if(p == -1){
				f = false;
				Console.WriteLine("I guessed it");
			}
			else if(p == 1){
				lowest = guess + 1;
			}
			else if(p == 2){
				higest= guess - 1;
			}
			else{
				continue;
			}
		}
	}
}
				