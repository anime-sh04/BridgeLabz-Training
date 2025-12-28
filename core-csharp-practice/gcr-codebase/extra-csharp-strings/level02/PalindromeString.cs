using System;

class PalindromeString{
	public static void input(){
		string s = Console.ReadLine();
		CheckPalindrome(s);
	}
	
	public static void CheckPalindrome(string s){
		
		int left =0;
		int right = s.Length-1;
		
		while(true){
			if(left >= right){
				break;
			}
			else if(s[left] == s[right]){
				left++;
				right--;
				continue;
			}
			
			else{
				Result(false);
				return;
			}
		}
		Result(true);
	}
	
	public static void Result(bool f){
		if(f)
			Console.WriteLine("Its a palin");
		else
			Console.WriteLine("Its not a palin");
	}
	
	
	static void Main(string[] args){
		input();
	}
}