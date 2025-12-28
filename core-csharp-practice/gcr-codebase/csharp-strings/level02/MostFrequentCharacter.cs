using System;

class MostFrequentCharacter{
	static void Main(string[] args){
		string s = Console.ReadLine();
		char most = ' ';
		int longest = 0;
		int count = 0;
		char c = ' ';
		
		foreach(char ch in s){
			for(int i=0;i<s.Length;i++){
				c = s[i];
				if(ch == c)
					count++;
			}
			if(count>longest){
				longest = count;
				most = c;
			}
			count =0;
		}
		
		Console.WriteLine("Most Frequent : " + most);
	}
}

