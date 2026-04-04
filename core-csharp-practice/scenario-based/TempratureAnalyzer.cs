/*
Arrays – Temperature Analyzer
 1. Scenario: You're analyzing a week’s worth of hourly temperature data stored in a 2D array
(float[7][24]).
Problem:
Write a method to:
 ● Find the hottest and coldest day,
 ● Return average temperature per day.*/
using System;

class TempratureAnalyzer{

    public static void HottestAndColdest(float[,] temp){
		float hottest = 0, coldest =0;
		float hottestAvg = 0, coldestAvg =10000;
		float avg = 0;
		for(int i=0;i<7;i++){
			avg = AverageTemprature(temp,i);
			if(avg > hottestAvg){
				hottestAvg = avg;
				hottest = i;
			}
			if(avg < coldestAvg){
				coldestAvg = avg;
				coldest = i;
			}
		}
		
		Console.WriteLine("Hottest day was : " + (hottest+1));
		Console.WriteLine("Coldest day was : " + (coldest+1));		
		return;
    }
	
	public static float AverageTemprature(float[,] temp, int n){
		float avgTemprature = 0;
		float sum =0;
		for(int i=0;i<24;i++){
			sum += temp[n,i];
		}
		avgTemprature = sum/24;
		
		return avgTemprature;
	}


	public static void input(){
		float[,] temp = new float[7,24];
		Console.WriteLine("Enter temperatures:");
			for(int i=0;i<7;i++){
				for(int j=0;j<24;j++){
					temp[i,j] = float.Parse(Console.ReadLine());
				}
			}
		
		while(true){
			Console.WriteLine("1. Hottest And Coldest Day");
			Console.WriteLine("2. Average Temprature per day");
			Console.WriteLine("3. Exit");
			
			int n = int.Parse(Console.ReadLine());
			switch(n){
				case 1:
					HottestAndColdest(temp);
					break;
				case 2:
					for(int i=0;i<7;i++){
						Console.WriteLine(AverageTemprature(temp,i));
					}
					break;
				case 3:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
    static void Main(){
		input();
    }
}
