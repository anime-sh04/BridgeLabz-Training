/*
"EduQuiz – Student Quiz Grader"
Story: You’re building the grading module for a quiz app. A student answers a 10-question quiz.
You must compare their answers to the correct ones, give feedback, and calculate scores.
Requirements:
● Use two String[] arrays: correctAnswers[] and studentAnswers[].
● Implement a method calculateScore(String[] correct, String[]
student) that returns a score.
● Use string comparison with .equalsIgnoreCase() for case-insensitive matching.
● Print detailed feedback: Question 1: Correct / Incorrect.
● Bonus: Show percentage score and pass/fail message.*/
using System;

class  StudentQuizGrader{
	static void Main(string[] args){
		StudentQuizGrader obj = new StudentQuizGrader();
		obj.input();
	}
	void input(){
		/* string[] correctAnswers = new string[10];
		string[] studentAnswers = new string[10];
		
		Console.WriteLine("Enter Correct answers : ");
		for(int i=0;i<10;i++)
			correctAnswers[i] = Console.ReadLine();
		
		Console.WriteLine("Enter Student answers : ");
		for(int i=0;i<10;i++)
			studentAnswers[i] = Console.ReadLine();  FOR MANUAL INPUT */
		
			
		string[] correctAnswers = {
			"Paris",
			"Java",
			"HyperText Markup Language",
			"CPU",
			"Earth",
			"Mount Everest",
			"William Shakespeare",
			"Pacific Ocean",
			"Einstein",
			"Python"
		};
		
		string[] studentAnswers = {
			"Paris",
			"C++",
			"HyperText Markup Language",
			"CPU",
			"Mars",
			"Mount Everest",
			"William Shakespeare",
			"Atlantic Ocean",
			"Einstein",
			"Python"
		};
		int studentScore = CalculateScore(correctAnswers,studentAnswers);
		double percentageScore = (studentScore/10.0)*100;
		
		if(percentageScore>35)
			Console.WriteLine("Student got "+percentageScore+"% and passed");
		else
			Console.WriteLine("Student got "+percentageScore+"% and failed");
	}
	
	int CalculateScore(string[] correctAnswers, string[] studentAnswers){
		int score = 0;
		for(int i=0;i<correctAnswers.Length;i++){
			if(correctAnswers[i].Equals(studentAnswers[i],StringComparison.OrdinalIgnoreCase)){
				Console.WriteLine("Question "+(i+1)+" Correct");
				score++;
			}
			else{
				Console.WriteLine("Question "+(i+1)+" Incorrect");
			}
		}
		return score;
	}
}
		
				
		
