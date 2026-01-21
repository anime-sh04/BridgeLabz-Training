class RemoveDuplicates
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>{1,3,4,5,5,6,7,7};

        HashSet<int> have = new HashSet<int>();
        List<int> result = new List<int>();
        foreach(int i in list)
        {
            if (!have.Contains(i))
            {
                have.Add(i);
                result.Add(i);
            }
        }

        foreach(int i in result)
        {
            Console.Write(i + " ");
        }
    }
}