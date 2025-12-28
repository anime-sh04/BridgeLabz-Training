using System;

class ToggleCase{
	static void Main(string[] args){
		string s = Console.ReadLine();
		string temp = "";
		
		foreach(char ch in s){
			if(ch > 65 && ch < (65+26))
				temp = temp+ (char)(ch+32);
			else
				temp = temp+(char)(ch-32);
		}
		
		Console.WriteLine("After ToggleCase : " + temp);
	}
}