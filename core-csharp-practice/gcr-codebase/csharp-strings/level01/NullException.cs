using System;

class NullException{
	public static void NullRefException(){
		string s = null;
		try{
            Console.WriteLine(s.Length);
		}catch(NullReferenceException ex){
			Console.WriteLine(ex.Message);
		}
	}
	
	static void Main(string[] args){
		NullRefException();
	}
}
