using System;
using System.Collections.Generic;

class SetToList
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int> {5,3,9,1};
        List<int> sortedList = new List<int>(set);
        
        for(int i =0; i < sortedList.Count; i++)
        {
            for(int j = i +1; j < sortedList.Count; j++)
            {
                if(sortedList[i] > sortedList[j])
                {
                    int temp = sortedList[i];
                    sortedList[i] = sortedList[j];
                    sortedList[j] = temp;
                }
            }
        }

        Console.Write("Output: ");
        foreach (int x in sortedList)
        {
            Console.Write(x + " ");
        }
    }
}
