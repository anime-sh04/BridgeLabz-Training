using System;

class ArgumentException{
	public static void OutOfRangeException(){
		string s = "animesh";
		try{
            Console.WriteLine(s.Substring(10,2));
		}catch(ArgumentOutOfRangeException ex){
			Console.WriteLine(ex.Message);
		}
	}
	
	static void Main(string[] args){
		OutOfRangeException();
	}
}
