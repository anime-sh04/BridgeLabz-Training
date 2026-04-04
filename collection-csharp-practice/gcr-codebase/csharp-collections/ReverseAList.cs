using System.Collections;
using System.Runtime.InteropServices;

class ReverseAList
{
    static void Main(string[] args)
    {
        ArrayList arr = new ArrayList();
        arr.Add(1);
        arr.Add(2);
        arr.Add(3);
        arr.Add(4);
        arr.Add(5);
        int end = arr.Count-1;
        int temp =0;
        for(int i = 0; i < arr.Count/2; i++)
        {
            temp = (int)arr[i];
            arr[i] = arr[end];
            arr[end] = temp;
            end--;
        }
        Console.WriteLine("Reversed ArrayList : ");

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }

        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);

        LinkedList<int> reversed = new LinkedList<int>();

        foreach (int i in list)
        {
            reversed.AddFirst(i);
        }

        Console.WriteLine("\nReversed LinkedList: ");
        foreach (int i in reversed)
            Console.Write(i + " ");
    }
}
