using System;

class LargestElement{
	static void Main(string[] args){
		
		long number = long.Parse(Console.ReadLine());
		
		long maxDigit = 10;
		long[] arr = new long[maxDigit];
		
		long index =0;
		
		while(number!=0){
			
			if(index == maxDigit){
				break;
			}
			long d = number% 10;
			arr[index] = d;
			number = number/10;
			index++;
		}
		long largest = 0, secondLargest = 0;
		
		for(long i =0;i<arr.Length;i++){
			if (arr[i] > largest){
                secondLargest = largest;
                largest = arr[i];
            }
            else if ((arr[i] > secondLargest) && (arr[i] != largest)){
                secondLargest = arr[i];
            }
		}
		Console.WriteLine("Largest = "+largest);
		Console.WriteLine("Second Largest = "+secondLargest);
	}
}
		
		