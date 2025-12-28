using System;

class StringComparison{
	public static bool compare(string s1 , string s2){
		if(s1.Length != s2.Length)
			return false;
			
		for(int i=0;i<s1.Length;i++){
			if(s1[i] == s2[i])
				continue;
			else
				return false;
		}
		return true;
	}
	
	static void Main(string[] args){
		string s1 = Console.ReadLine();
		string s2 = Console.ReadLine();
		
		Console.WriteLine((s1.Equals(s2))?"Equal with IsEqual" : "Not Equal with IsEqual");
		
		if(compare(s1,s2))
			Console.WriteLine("With method Equal");
		else
			Console.WriteLine("With Method not Equal");
	}
}