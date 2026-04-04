/*Scenario: Create a program that analyzes a given paragraph of text. Implement the following
functionalities:
● Count the number of words in the paragraph.
● Find and display the longest word.
● Replace all occurrences of a specific word with another word (case-insensitive).
● Handle edge cases like empty strings or paragraphs with only spaces.*/
using System;

class ParagraphAnalyze{
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
		return newString;
	}
	
	public static int NumberOfWords(string s){
		int c =0;
		foreach(char ch in s){
			if(ch == ' ')
				c++;
		}
		c++;
		return c;
	}
	
	public static string LongestWord(string s){
		string longest = "";
		string newString ="";
		string temp = s + " ";
		for(int i=0;i<temp.Length;i++){
			if(temp[i] == ' '){
				if(newString.Length > longest.Length){
					longest = newString;
				}
				newString = "";
			}
			else{
				newString += temp[i];
			}
		}
		return longest;
	}
	
	public static string ReplaceOccurrence(string s, string replaceWith, string replaceTo){
		string newString = "";
		string word = "";
	
		for(int i=0;i<=s.Length;i++){
			if(i == s.Length || s[i] == ' '){
				if(word.Length > 0){
					if(word.ToLower() == replaceWith.ToLower()){
						newString += replaceTo;
					}
					else{
						newString += word;
					}
					word = "";
				}
	
				if(i < s.Length)
					newString += " ";
			}
			else{
				word += s[i];
			}
		}

		return newString;
	}



	public static void menu(){
		string s = Console.ReadLine();
		while(true){
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("1. Count the number of words in the paragraph");
			Console.WriteLine("2. Find and get the longest word");
			Console.WriteLine("3. Replace all occurrences of a specific word with another word (case-insensitive).");
			Console.WriteLine("4. exit");
			Console.WriteLine("-------------------------------------");
			int n = int.Parse(Console.ReadLine());
			
			switch(n){
				case 1:
					Console.WriteLine("Number Of Words in the Paragraph are : "+NumberOfWords(TrimFunc(s)));
					break;
				case 2:
					Console.WriteLine("Longest word in paragraph is : " +LongestWord(s));
					break;
				case 3:
					string replaceWith = Console.ReadLine();
					string replaceTo= Console.ReadLine();
					
					Console.WriteLine(ReplaceOccurrence(s,replaceWith, replaceTo));
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
		
	static void Main(string[] args){
		menu();
	}
}