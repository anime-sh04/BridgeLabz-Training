using System;

class MyHashMap
{
    class Node
    {
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private Node[] table;
    private int capacity;

    public MyHashMap(int capacity)
    {
        this.capacity = capacity;
        table = new Node[capacity];
    }

    private int Hash(int key)
    {
        return Math.Abs(key) % capacity;
    }

    // Insert
    public void Put(int key, int value)
    {
        int index = Hash(key);

        Node head = table[index];

        Node curr = head;
        while (curr != null)
        {
            if (curr.Key == key)
            {
                curr.Value = value;
                return;
            }
            curr = curr.Next;
        }

        Node newNode = new Node(key, value);
        newNode.Next = head;
        table[index] = newNode;
    }

    public int Get(int key)
    {
        int index = Hash(key);
        Node curr = table[index];

        while (curr != null)
        {
            if (curr.Key == key)
                return curr.Value;
            curr = curr.Next;
        }

        return -1; 
    }

    // Delete
    public void Remove(int key)
    {
        int index = Hash(key);
        Node curr = table[index];
        Node prev = null;

        while (curr != null)
        {
            if (curr.Key == key)
            {
                if (prev == null)
                    table[index] = curr.Next;
                else
                    prev.Next = curr.Next;
                return;
            }
            prev = curr;
            curr = curr.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap(10);

        map.Put(1, 100);
        map.Put(11, 200);
        map.Put(2, 300);

        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(11));

        map.Remove(1);
        Console.WriteLine(map.Get(1));
    }
}
