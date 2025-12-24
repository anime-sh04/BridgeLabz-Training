using System;

class YoungestAndTAllest{
	static void Main(string[] args){
		
		int[] age = new int[3];
		int[] height = new int[3];
		
		for(int i=0;i<3;i++){
			age[i] = int.Parse(Console.ReadLine());
		}
		for(int i=0;i<3;i++){
			height[i] = int.Parse(Console.ReadLine());
		}
		
		int j =0;
		if((age[j] < age[j+1]) && (age[j] < age[j+2])){
			Console.WriteLine("Amar is Youngest");
		}
		else if((age[j+1] < age[j]) && (age[j+1] < age[j+2])){
			Console.WriteLine("Akbar is Youngest");
		}
		else{
			Console.WriteLine("Anthony is Youngest");
		}
		
		if((height[j] > height[j+1]) && (height[j]>height[j+2])){
			Console.WriteLine("Amar is Tallest");
		}
		else if((height[j] < height[j+1]) && (height[j+2]<height[j+1])){
			Console.WriteLine("Akbar is Tallest");
		}
		else{
			Console.WriteLine("Anthony is Tallest");
		}
	}
}

		
		