/*Scenario: A text editing tool receives poorly formatted input from users. Your task is to auto-correct formatting by fixing spacing and capitalizing the first letter of each sentence.
Problem:
Write a method that takes a paragraph as input and returns a corrected version with:
● One space after punctuation,
● Capital letter after period/question/exclamation marks,
● Trimmed extra spaces.*/
using System;

class SentenceFormatter{
	/* A program to format your sentence/paragraph which include different functions for every task
	like SpaceAfterPunctuation() to add space after punctuation , TrimFunc() to trim the spaces,
	Capital() to make the first character and character after punctuation capital.*/
	
	public static string TrimFunc(string para){
		int start =0, end =0;
		string newString = "";

		for(int i=0;i<para.Length;i++){
			if(para[i] != ' '){
				start = i;
				break;
			}
		}
		for(int i=para.Length-1;i>=0;i--){
			if(para[i] != ' '){
				end = i;
				break;
			}
		}
		for(int i=start;i<=end;i++){
			char ch = para[i];
			newString += ch;
		}
		Console.WriteLine("\nAfter Trimmed : " + newString);
		return SpaceAfterPunctuation(newString);
	}
	public static string SpaceAfterPunctuation(string s){
		string newString = "";
		foreach(char ch in s){
			if(ch == '.' || ch == ',' || ch == '?' || ch == '!' || ch == ':' || ch == ';' || ch == '-')
				newString += ch + " ";
			else 
				newString += ch;
		}
		Console.WriteLine("\nAfter Giving Space After Punctuation : " + newString);
		return Capital(newString);
	}
	public static string Capital(string s){
		string newString = "";
		if(s[0] >= 97 && s[0] <= (97+26))
			newString += (char)(s[0] -32);
		else
			newString += s[0];
			
		for(int i =1;i<s.Length;i++){
			if(s[i] == '.' || s[i] == ',' || s[i] == '!'){
				newString += s[i];
				if(s[i+2] >= 97 && s[i+2] <= (97+26)){
					newString += " " + (char)(s[i+2] - 32);
					i= i+2;
				}
			}
			else
				newString += s[i];
		}
		Console.WriteLine("\nAfter Giving Capital after Punctuation : " + newString);
		return newString;
	}
	
	public static void input(){
		string s = Console.ReadLine();
		Console.WriteLine("\nFINALLY : " +TrimFunc(s));
	}
		
	static void Main(string[] args){
		input();
	}
}
		