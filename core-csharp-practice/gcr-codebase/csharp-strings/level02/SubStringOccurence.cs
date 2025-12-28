using System;

class SubStringOccurence{
	static void Main(string[] args){
		string s = Console.ReadLine();
		string sub = Console.ReadLine();
		int c=0;
		string temp = "";
		
		for(int i=0;i<s.Length-sub.Length;i++){
			temp = s.Substring(i,sub.Length);
			if(temp == sub)
				c++;
		}
				
		Console.WriteLine("Occurence : " + c);
	}
}