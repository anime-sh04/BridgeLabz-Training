using System;

class SubString{
	
	public static string CheckSubString(string s, int a, int b){
		string temp ="";
		while(a!=b){
			temp = temp + s[a];
			a++;
		}
		return temp;
	}
			
	static void Main(string[] args){
		string s = Console.ReadLine();
		int startidx = int.Parse(Console.ReadLine());
		int endidx = int.Parse(Console.ReadLine());
		
		Console.WriteLine("SubString with s.substring : " + (s.Substring(startidx,endidx)));
		Console.WriteLine("SubString with Methods : " + (CheckSubString(s,startidx,endidx)));
	}
}
		
		
		