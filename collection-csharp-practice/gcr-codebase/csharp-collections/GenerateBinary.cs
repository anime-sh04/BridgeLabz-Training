class GenerateBinaryUsingQueue
{
    static void Main()
    {
        int n = 5;
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string s1 = q.Dequeue();
            Console.WriteLine(s1);

            string s2 = s1;
            q.Enqueue(s1 + "0");
            q.Enqueue(s2 + "1");
        }
    }
}