class FindFrequencyofElements
{
    static void Main(string[] args)
    {
        List<string> l = new List<string> { "Apple", "Banana", "Orange","Apple"};

        Dictionary<string,int> dict = new Dictionary<string, int>();

        // foreach (string item in l)
        // {
        //     dict[item] = 0; 
        // }

        for(int i = 0; i < l.Count; i++)
        {
            if (dict.ContainsKey(l[i]))
            {
                dict[l[i]]++;
            }
            else
            {
                dict[l[i]] = 1;
            }
        }
        foreach (KeyValuePair<string, int> item in dict)
        {
            Console.WriteLine(item.Key + " :" + item.Value);
        }
    }
}