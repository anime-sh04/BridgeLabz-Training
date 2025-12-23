using System;

class TwoDArray{
	static void Main(string[] args){
		
		Console.Write("Enter Rows :");
		int rows = int.Parse(Console.ReadLine());
		Console.Write("Enter Columns :");
		int columns = int.Parse(Console.ReadLine());
		
		int[,] arr = new int[rows,columns];
		
		Console.Write("Enter 2D values : ");
		
		for(int i =0;i<rows;i++){
			for(int j =0;j<columns;j++){
				arr[i,j] = int.Parse(Console.ReadLine());
			}
		}
		
		int[] oneD = new int[rows*columns];
		
		int index =0;
		
		for(int i =0;i<rows;i++){
			for(int j =0;j<columns;j++){
				oneD[index] = arr[i,j];
				index++;
			}
		}
		
		for(int i=0;i<oneD.Length;i++){
			Console.Write(oneD[i] + " ");
		}
	}
}

		