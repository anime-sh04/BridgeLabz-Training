using System;
using System.Diagnostics;
using System.Text;

class CompareStringBuilder
{
    static void Main(string[] args)
    {
        int n = 100000;

        // Using String
        DateTime start1 = DateTime.Now;

        string s = "";
        for (int i = 0; i < n; i++)
        {
            s += "a";
        }

        DateTime end1 = DateTime.Now;
        TimeSpan time1 = end1 - start1;

        // Using StringBuilder
        DateTime start2 = DateTime.Now;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }

        DateTime end2 = DateTime.Now;
        TimeSpan time2 = end2 - start2;

        Console.WriteLine("String Time: " + time1.TotalMilliseconds + " ms");
        Console.WriteLine("StringBuilder Time: " + time2.TotalMilliseconds + " ms");
    }
}
