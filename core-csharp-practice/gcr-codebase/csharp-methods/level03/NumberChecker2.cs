using System;

class NumberChecker1
{
    public static int Count(int n){
        int c = 0;
        while (n !=0){
            c++;
            n=n/10;
        }
        return c;
    }

    public static int[] Digits(int n,int c){
        int[] a = new int[c];
        int idx = 0;

        for (int i=n;i!=0;i=i/10){
            int d = i%10;
            a[idx] = d;
            idx++;
        }
        return a;
    }

    public static int SumOfDigits(int[] a){
        int sum =0;
        for (int i=0;i<a.Length;i++)
            sum = sum + a[i];
        return sum;
    }

    public static double SumOfSquaresOfDigits(int[] a){
        double sum = 0;
        for (int i=0;i<a.Length;i++)
            sum += Math.Pow(a[i],2);
        return sum;
    }

    public static bool IsHarshad(int number,int[] digits){
        int sum = SumOfDigits(digits);
		bool temp = (number%sum == 0);
        return temp;
    }

    public static int[,] DigitFrequency(int[] digits){
        int[,] freq = new int[10,2];

        for (int i=0;i<10;i++)
            freq[i,0] = i;

        for (int i=0;i<digits.Length;i++)
            freq[digits[i],1]++;

        return freq;
    }

    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());

        int count = Count(number);
        int[] digits = Digits(number,count);

        Console.WriteLine("Digits:");
        for (int i=0;i<digits.Length;i++)
            Console.Write(digits[i] + " ");

        int sum = SumOfDigits(digits);
        double squareSum = SumOfSquaresOfDigits(digits);

        Console.WriteLine("Sum of digits" +sum);
        Console.WriteLine("Sum of squares of digits"+squareSum);
		
		if(IsHarshad(number,digits))
			Console.WriteLine("Harshad Number");
		else
			Console.WriteLine("Not Harshad Number");

        int[,] frequency = DigitFrequency(digits);

        Console.WriteLine("Digit  Frequency");
        for (int i=0;i<10;i++)
        {
            if (frequency[i,1]> 0)
                Console.WriteLine(frequency[i,0] + " " + frequency[i,1]);
        }
    }
}
