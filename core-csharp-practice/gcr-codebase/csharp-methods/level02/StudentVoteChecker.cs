using System;

class StudentVoteChecker{
	
	public static bool CanStudentVote(int age){
		if(age <0){
			return false;
		}
		if(age>18){
			return true;
		}
		else{
			return false;
		}
	}
			
	static void Main(string[] args){
		
		int[] age = new int[10];
		
		for(int i=0;i<10;i++){
			age[i] = int.Parse(Console.ReadLine());
		}
		for(int i=0;i<10;i++){
			Console.WriteLine(CanStudentVote(age[i]));
		}
	}
}