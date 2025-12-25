using System;

class SumOfNaturalNumbers
{
    public static int Sum(int n){
        int sum = 0;

        for (int i=1;i<=n;i++){
            sum = sum + i;
        }

        return sum;
    }

    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());

        int result = Sum(n);

        Console.WriteLine(result);
    }
}
