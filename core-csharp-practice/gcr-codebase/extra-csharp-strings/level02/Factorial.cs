using System;

class FactorialR{
    public static int Input(){
        return int.Parse(Console.ReadLine());
    }

    public static long Factorial(int n){
        if (n == 0 || n == 1)
            return 1;

        return n*Factorial(n - 1);
    }

    public static void Output(long result){
        Console.WriteLine("Factorial :" + result);
    }

    static void Main(string[] args){
        int num = Input();
        long result = Factorial(num);
        Output(result);
    }
}
