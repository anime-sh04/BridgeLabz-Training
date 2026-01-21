using System;
using System.Collections.Generic;

class NthFromEnd
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");
        list.AddLast("D");
        list.AddLast("E");

        Console.Write("Enter N: ");
        int toFind = int.Parse(Console.ReadLine());

        LinkedListNode<string> fast = list.First;
        LinkedListNode<string> slow = list.First;
        
        for (int i = 0; i < toFind; i++)
        {
            if (fast == null)
            {
                Console.WriteLine("N is larger than list length");
                return;
            }
            fast = fast.Next;
        }

        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        Console.WriteLine("Output: " + slow.Value);
    }
}
