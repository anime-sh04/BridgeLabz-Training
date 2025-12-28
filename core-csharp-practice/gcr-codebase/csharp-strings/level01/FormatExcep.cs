using System;

class FormatExcep{
	public static void FormatEx(){
		try{
			int n = int.Parse(Console.ReadLine());
		}catch(FormatException ex){
			Console.WriteLine("Got Exception");
			Console.WriteLine(ex.Message);
		}
	}
	static void Main(string[] args){
		FormatEx();
	}
}
		