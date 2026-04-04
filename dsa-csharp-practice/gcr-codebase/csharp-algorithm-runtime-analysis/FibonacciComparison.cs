using System;
using System.Diagnostics;

class FibonacciComparison
{
    static void Main()
    {
        int[] tests = { 10, 30, 50 };

        foreach (int n in tests)
        {
            Console.WriteLine("\nFibonacci "+n);

            Stopwatch sw = new Stopwatch();

            if (n <= 50)   // Recursive becomes unusable beyond this
            {
                sw.Start();
                int r1 = FibonacciRecursive(n);
                sw.Stop();
                Console.WriteLine("Recursive: "+sw.ElapsedMilliseconds+" ms");
                sw.Reset();
            }
            else
                Console.WriteLine("Recursive: Skipped (Too Slow)");

            sw.Start();
            int r2 = FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine("Iterative: "+sw.ElapsedMilliseconds+" ms");
        }

        Console.ReadLine();
    }

    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        if (n == 0) return 0;

        int a = 0, b = 1, sum;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
