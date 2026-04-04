using System;

class ReverseString{
	static void Main(string[] args){
		string s = Console.ReadLine();
		string newString = "";
		for(int i =s.Length-1;i>=0;i--){
			char ch = s[i];
			newString+= ch;
		}
		Console.WriteLine("Reversed String : " + newString);
	}
}