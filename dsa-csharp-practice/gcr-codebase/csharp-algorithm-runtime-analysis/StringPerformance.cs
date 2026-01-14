using System;
using System.Diagnostics;
using System.Text;

class StringPerformance
{
    static void Main(string[] args)
    {
        int[] counts = { 1000, 10000, 1000000 };

        foreach (int n in counts)
        {
            Console.WriteLine("\nOperations: "+n);

            Stopwatch sw = new Stopwatch();

            // Using string
            if (n <= 10000) // skip large test (too slow)
            {
                sw.Start();
                string result = "";
                for (int i = 0; i < n; i++)
                    result += "A";
                sw.Stop();
                Console.WriteLine("string: "+sw.ElapsedMilliseconds+"ms");
                sw.Reset();
            }
            else
                Console.WriteLine("string: Skipped (Too Slow)");

            // Using StringBuilder
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                sb.Append("A");
            sw.Stop();
            Console.WriteLine("StringBuilder: "+sw.ElapsedMilliseconds+" ms");
        }

        Console.ReadLine();
    }
}
