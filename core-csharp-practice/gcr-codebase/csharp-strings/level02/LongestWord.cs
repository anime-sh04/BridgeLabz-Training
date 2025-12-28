using System;

class LongestWord{
	public static int GetLength(string s){
		int count = 0;
        foreach(char ch in s)
            count++;
			
        return count;
    }
	static void Main(string[] args){
		string s = Console.ReadLine();
		string newString = "";
		int longest = 0;
		int c=0;
		string temp = "";
		
		foreach(char ch in s){
			if(ch != ' '){
				temp= temp + (char)ch;
			}
			else{
				c = GetLength(temp);
				if(c>longest){
					newString = temp;
					longest = c;
				}
				temp = "";
			}
		}
				
		Console.WriteLine("Longest Word : " + newString);
	}
}