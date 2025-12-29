/*
 2. Scenario: Develop a program to manage student test scores. The program should:
 ● Store the scores of n students in an array.
 ● Calculate and display the average score.
 ● Find and display the highest and lowest scores.
 ● Identify and display the scores above the average.
 ● Handle invalid input like negative scores or non-numeric input.;
 */
using System;
class StudentTestScores{
	
	public static void ScoresAboveAverage(float[] scores){
		float avg = AverageScore(scores);
		for(int i=0;i<scores.Length;i++){
			if(scores[i]>avg){
				Console.WriteLine("Student "+ (i+1) + " got the score above average : " + scores[i]);
			}
		}
		return;
	}
	
	public static void HighestAndLowest(float[] scores){
		float highest =0, lowest = int.MaxValue;
		int identifyHighest =0, identifyLowest =0;
		for(int i=0;i<scores.Length;i++){
			if(scores[i]>highest){
				highest =scores[i];
				identifyHighest = i;
			}
			
			if(scores[i]<lowest){
				lowest= scores[i];
				identifyLowest = i;
			}
		}
		
		Console.WriteLine("Student "+ (identifyHighest+1) + " got the Highest Score : " + highest);
		Console.WriteLine("Student "+ (identifyLowest+1) + " got the Lowest Score : " + lowest);
		
		return;
	}
		
	public static float AverageScore(float[] scores){
		float sum =0;
		for(int i=0;i<scores.Length;i++)
			sum += scores[i];
		
		return (sum/scores.Length);
	}
	
			
	public static void input(){
		Console.WriteLine("Enter Number of students");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter scores");
		float[] scores = new float[n];
		for(int i=0;i<n;i++){
			
			float pp = float.Parse(Console.ReadLine());
			if(pp < 0){
				Console.WriteLine("Enter a valid score");
			}
			else{
				score[i] = pp;
			}
		}
		
		
		while(true){
			Console.WriteLine("1. Average Score");
			Console.WriteLine("2. Display Highest and Lowest scores");
			Console.WriteLine("3. Display Scores above Average");
			Console.WriteLine("4. Exit");
			
			int chose = int.Parse(Console.ReadLine());
			switch(chose){
				case 1:
					Console.WriteLine("Average Score : " + AverageScore(scores));
					break;
				case 2:
					HighestAndLowest(scores);
					break;
				case 3:
					ScoresAboveAverage(scores);
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
					
		
	static void Main(string[] args){
		input();
	}
}