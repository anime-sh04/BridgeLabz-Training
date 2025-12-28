using System;

class RemoveCharacter{
	static void Main(string[] args){
		string s = Console.ReadLine();
		char toRemove = char.Parse(Console.ReadLine());
		string temp = "";
		
		foreach(char ch in s){
			if(ch == toRemove)
				continue;
			else
				temp = temp + (char)ch;
		}
			
		
		Console.WriteLine("After Removing Character : " + temp);
	}
}