using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Stack<int> s = new Stack<int>();
        
        while (q.Count > 0)
        {
            s.Push(q.Dequeue());
        }

        while (s.Count > 0)
        {
            q.Enqueue(s.Pop());
        }

        Console.Write("Output: ");
        foreach (int x in q)
        {
            Console.Write(x + " ");
        }
    }
}
