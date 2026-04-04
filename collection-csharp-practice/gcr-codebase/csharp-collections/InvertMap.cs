using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>(){{"A", 1},{"B", 2},{"C", 1}};

        Dictionary<int, List<string>> inverted =
            new Dictionary<int, List<string>>();

        foreach (var pair in input)
        {
            if (!inverted.ContainsKey(pair.Value))
            {
                inverted[pair.Value] = new List<string>();
            }

            inverted[pair.Value].Add(pair.Key);
        }

        // Print result
        foreach (var item in inverted)
        {
            Console.Write(item.Key + " = [");
            Console.Write(string.Join(", ", item.Value));
            Console.WriteLine("]");
        }
    }
}
