using System;

class Fibonacci{
    public static void FibonacciS(int n){
        int a=0,b= 1;

        for (int i =1;i<=n;i++){
            Console.Write(a + " ");
            int temp= a+ b;
            a =b;
            b = temp;
        }
    }

    static void Main(){
        int n = int.Parse(Console.ReadLine());
        FibonacciS(n);
    }
}
