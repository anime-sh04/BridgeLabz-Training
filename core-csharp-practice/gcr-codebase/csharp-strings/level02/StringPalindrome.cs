using System;

class StringPalindrome{
	static void Main(string[] args){
		string s = Console.ReadLine();
		string newString = "";
		for(int i =s.Length-1;i>=0;i--){
			char ch = s[i];
			newString+= ch;
		}
		if(newString == s)
			Console.WriteLine("It is a Palindrome");
		else
			Console.WriteLine("It is not a Palindrome");
	}
}