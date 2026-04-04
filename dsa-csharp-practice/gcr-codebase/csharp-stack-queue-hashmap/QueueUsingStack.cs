using System;
using System.Collections.Generic;

class QueueUsingStack
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();

    // Enqueue operation
    public void Enqueue(int x)
    {
        stack1.Push(x);
        Console.WriteLine($"Enqueued: {x}");
    }

    // Dequeue operation
    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        int val = stack2.Pop();
        Console.WriteLine($"Dequeued: {val}");
        return val;
    }

    static void Main()
    {
        QueueUsingStack q = new QueueUsingStack();

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        q.Dequeue();
        q.Dequeue();

        q.Enqueue(40);
        q.Dequeue();
        q.Dequeue();
    }
}
