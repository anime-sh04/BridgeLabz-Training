using System;

class AgeCheck{
	static void Main(string[] args){
		
		int[] age = new int[10];
		
		for(int i =0;i<10;i++){
			age[i] = int.Parse(Console.ReadLine());
		}
		
		for(int i =0;i<age.Length;i++){
			if(age[i] < 0){
				Console.WriteLine("Invalid Age");
			}
			else if(age[i] >= 18){
				Console.WriteLine("The Student with age "+age[i]+" can vote");
			}
			else{
				Console.WriteLine("The Student with age "+age[i]+" cannot vote");
			}
		}
	}
}
