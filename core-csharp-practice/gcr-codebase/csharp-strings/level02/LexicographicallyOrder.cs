using System;

class LexicographicallyOrder{
	static void Main(string[] args){
		string s = Console.ReadLine();
		string s2 = Console.ReadLine();
		
		int i=-1;
		while(true){
			i++;
			if(i == s.Length){
				Console.WriteLine(s +" comes before " + s2+ " in lexicographically order");
				break;
			}
			else if(i == s2.Length){
				Console.WriteLine(s2 +" comes before " + s +" in lexicographically order");
				break;
			}
			else if(s[i] < s2[i]){
				Console.WriteLine(s +" comes before " + s2 +" in lexicographically order");
				break;
			}
			else if(s2[i] < s[i]){
				Console.WriteLine(s2 +" comes before " + s +" in lexicographically order");
				break;
			}
			
			else
				continue;
		}
	}
}