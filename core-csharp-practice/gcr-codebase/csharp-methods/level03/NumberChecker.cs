using System;

class NumberCheck{
	public static int Count(int n){
		int c=0;
		while(n!=0){
			c++;
			n=n/10;
		}
		return c;
	}
	public static int[] Digits(int n, int c){
		int[] a = new int[c];
		int idx =0;
		for(int i=n;i!=0;i=i/10){
			int d = i%10;
			a[idx] = d;
			idx++;
		}
		return a;
	}
	public static bool Duck(int[] a){
		for(int i=0;i<a.Length;i++){
			if(a[i] !=0)
				return true;
		}
		return false;
	}
	public static bool Armstrong(int[] a, int c, int n){
		double sum = 0;
		for(int i=0;i<a.Length;i++){
			sum = sum + Math.Pow(a[i],c);
		}
		if(sum == n)
			return true;
		else
			return false;
	}
	
	public static int[] Largest(int[] a){
		int largest =Int32.MinValue , secondLargest = Int32.MinValue;
		
		for(int i=0;i<a.Length;i++){
			if (a[i] > largest){
                secondLargest = largest;
                largest = a[i];
            }
            else if (a[i] > secondLargest && a[i] != largest){
                secondLargest = a[i];
            }
		}
		int[] large = new int[2];
		large[0] = largest;
		large[1] = secondLargest;
		return large;
	}
	
	public static int[] Smallet(int[] a){
		int smallest =Int32.MaxValue , secondSmallest = Int32.MaxValue;
		
		for(int i=0;i<a.Length;i++){
			if (a[i] < smallest){
                secondSmallest = smallest;
                smallest = a[i];
            }
            else if (a[i] < secondSmallest && a[i] != smallest){
                secondSmallest = a[i];
            }
		}
		int[] small = new int[2];
		small[0] = smallest;
		small[1] = secondSmallest;
		return small;
	}
	
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine("Count +" + Count(number));
		
		int[] arr = Digits(number, Count(number));
		for(int i=0;i<arr.Length;i++){
			Console.WriteLine(arr[i] + " ");
		}
		if(Duck(arr))
			Console.WriteLine("Is duck");
		else
			Console.WriteLine("Not duck");
		
		if(Armstrong(arr, Count(number), number))
			Console.WriteLine("Is Armstrong");
		else
			Console.WriteLine("Not Armstrong");
		
		int[] small = Smallet(arr);
		for(int i=0;i<2;i++){
			Console.WriteLine("Smallest "+(i+1)+ " = " +small[i]);
		}
		int[] large = Largest(arr);
		for(int i=0;i<2;i++){
			Console.WriteLine("Largest "+(i+1)+ " = " +large[i]);
		}
	}
}
		
		
		
		
		