using System;
using System.Collections.Generic;

class StockSpan
{
    static int[] CalculateSpan(int[] price)
    {
        int n = price.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
            {
                stack.Pop();
            }

            if (stack.Count == 0)
                span[i] = i + 1;
            else
                span[i] = i - stack.Peek();

            stack.Push(i);
        }

        return span;
    }

    static void Main()
    {
        int[] price = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(price);

        Console.WriteLine("Stock Prices: ");
        foreach (int p in price) Console.Write(p + " ");

        Console.WriteLine("\nSpans: ");
        foreach (int s in span) Console.Write(s + " ");
    }
}
