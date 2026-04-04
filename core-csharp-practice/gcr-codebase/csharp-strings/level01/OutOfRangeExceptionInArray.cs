using System;

class OutOfRangeExceptionInArray{
	static void Main(string[] args){
		int[] arr = {1,2,3,4};
		try{
			Console.WriteLine(arr[5]);
		}catch(IndexOutOfRangeException ex){
			Console.WriteLine("Got Exception : ");
			Console.WriteLine(ex.Message);
		}
	}
}