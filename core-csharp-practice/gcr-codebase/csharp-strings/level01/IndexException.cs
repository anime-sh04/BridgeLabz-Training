using System;

class IndexException{
	public static void OutOfRangeException(){
		string s = "animesh";
		try{
            Console.WriteLine(s[9]);
		}catch(IndexOutOfRangeException ex){
			Console.WriteLine(ex.Message);
		}
	}
	
	static void Main(string[] args){
		OutOfRangeException();
	}
}
