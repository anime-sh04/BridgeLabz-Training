using System;
using System.Collections.Generic;

class HospitalTriage
{
    static void Main()
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        // Enqueue patients (negative severity for max-priority behavior)
        pq.Enqueue("John", -3);
        pq.Enqueue("Alice", -5);
        pq.Enqueue("Bob", -2);

        Console.Write("Treatment Order: ");

        while (pq.Count > 0)
        {
            string patient = pq.Dequeue();
            Console.Write(patient + " ");
        }
    }
}
