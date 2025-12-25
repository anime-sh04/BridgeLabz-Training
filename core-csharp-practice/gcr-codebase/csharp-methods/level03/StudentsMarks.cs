using System;

class StudentsMarks{
	static Random r= new Random();

	public static int[,] GenerateScores(int n){
		int[,] scores= new int[n,3];
		for(int i=0;i<n;i++){
			scores[i,0]=r.Next(10,100);
			scores[i,1]=r.Next(10,100);
			scores[i,2]=r.Next(10,100);
		}
		return scores;
	}

	public static double[,] CalculateResults(int[,] scores){
		int n = scores.GetLength(0);
		double[,] result = new double[n,3];

		for(int i=0;i<n;i++){
			int total=scores[i,0]+scores[i,1]+scores[i,2];
			double avg=total/3.0;
			double percent=(total/300.0)*100;

			result[i,0]=total;
			result[i,1]=Math.Round(avg,2);
			result[i,2]=Math.Round(percent,2);
		}
		return result;
	}

	public static void Display(int[,] scores,double[,] result){
		for(int i=0;i<scores.GetLength(0);i++){
			Console.WriteLine("Student "+(i+1));
			Console.WriteLine("Physics: "+scores[i,0]);
			Console.WriteLine("Chemistry: "+scores[i,1]);
			Console.WriteLine("Maths: "+scores[i,2]);
			Console.WriteLine("Total: "+result[i,0]);
			Console.WriteLine("Average: "+result[i,1]);
			Console.WriteLine("Percentage: "+result[i,2]);
			Console.WriteLine();
		}
	}

	static void Main(string[] args){
		int n=int.Parse(Console.ReadLine());

		int[,] scores=GenerateScores(n);
		double[,] result=CalculateResults(scores);
		Display(scores,result);
	}
}
