using System;

class CountVowelsAndConsonants{
	static void Main(string[] args){
		int vowels = 0;
		int consonants =0;
		string s = Console.ReadLine();
		foreach(char ch in s){
			char c = char.ToLower(ch);
			if(c == 'a' ||c == 'e' ||c == 'i' ||c == 'o' ||c == 'u')
				vowels++;
			else
				consonants++;
		}
		Console.WriteLine("Vowels = " + vowels);
        Console.WriteLine("Consonants = " + consonants);
	}
}