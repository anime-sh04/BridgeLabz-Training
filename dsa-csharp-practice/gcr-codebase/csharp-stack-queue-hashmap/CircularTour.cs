using System;

class CircularTour
{
    static int FindStartingPoint(int[] petrol, int[] dist)
    {
        int n = petrol.Length;

        int start = 0;
        int surplus = 0;
        int deficit = 0;

        for (int i = 0; i < n; i++)
        {
            surplus += petrol[i] - dist[i];

            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        if (surplus + deficit >= 0)
            return start;
        else
            return -1;
    }

    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] dist = { 6, 5, 3, 5 };

        int start = FindStartingPoint(petrol, dist);

        if (start == -1)
            Console.WriteLine("No possible tour");
        else
            Console.WriteLine("Start at petrol pump index: " + start);
    }
}
