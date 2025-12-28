using System;

class Anagram{
    static void Main(){
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        if (s1.Length!= s2.Length){
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] freq = new int[256];
        foreach (char ch in s1)
            freq[ch]++;

        foreach (char ch in s2)
            freq[ch]--;

        foreach (int count in freq){
            if (count != 0){
                Console.WriteLine("They are not Anagrams");
                return;
            }
        }

        Console.WriteLine("They are Anagrams");
    }
}
