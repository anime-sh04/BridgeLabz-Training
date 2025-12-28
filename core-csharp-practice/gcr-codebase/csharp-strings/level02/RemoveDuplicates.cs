using System;

class RemoveDuplicates{
	static void Main(string[] args){
		string s = Console.ReadLine();
		string newString = "";
		foreach(char ch in s){
			bool f = false;
			foreach(char c in newString){
				if(c==ch){
					f = true;
					break;
				}
			}
			if(!f)
				newString+=ch;
		}
		Console.WriteLine("Without Duplicates : " + newString);
	}
}