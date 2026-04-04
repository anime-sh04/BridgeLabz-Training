using System;

class TextToUpperCase{
	public static void ConvertCase(string s){
		Console.WriteLine("With ASCII logic : " );
		for(int i=0;i<s.Length;i++){
			char ch = s[i];
			if(ch >= 'a' && ch<= 'z')
				ch = (char)(ch-32);
			Console.Write(ch);
		}
		Console.WriteLine();
	}
	static void Main(string[] args){
		string s = Console.ReadLine();
		ConvertCase(s);
		Console.WriteLine("With buit In : " + s.ToUpper());
	}
}