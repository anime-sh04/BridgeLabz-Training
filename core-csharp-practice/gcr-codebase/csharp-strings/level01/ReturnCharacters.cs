using System;

class ReturnCharacters{
	public static void ReturnChar(string s){
		for(int i=0;i<s.Length;i++){
			Console.Write(s[i] + " ");
		}
		Console.WriteLine();
	}
	
	static void Main(string[] args){
		string s = Console.ReadLine();
		Console.WriteLine("With Method");
		ReturnChar(s);
		
		Console.WriteLine("With ToCharArray");
		char[] arr = s.ToCharArray();
		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[i] + " ");
		}
	}
}
