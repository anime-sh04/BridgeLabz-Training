class LexicalUtil
{
    public void isReversed(string firstWord,string secondWord)
    {
        bool reversed = true;
        if (firstWord.Length != secondWord.Length)
        {
            reversed = false;
        }
        else
        {
            int end = firstWord.Length-1;
            for(int i = 0; i < firstWord.Length; i++)
            {
               if (char.ToLower(firstWord[i]) != char.ToLower(secondWord[end]))
                {
                    reversed = false;
                    break;
                }
                else
                {
                    end--;
                    continue;
                }
            }
        }

        if (reversed)
        {
            reverseFirstWord(firstWord);
        }
        else
        {
            combineBothWord(firstWord,secondWord);
        }
    }
    public void reverseFirstWord(string firstWord)
    {
        string reversedFirst = "";
        for(int i = firstWord.Length-1; i>=0; i--)
        {
            reversedFirst += firstWord[i];
        }
        reversedFirst = reversedFirst.ToLower();
        replaceVowel(reversedFirst);
    }
    public void replaceVowel(string firstWord)
    {
        string replaced = "";
        foreach(char ch in firstWord)
        {
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                replaced+= "@";
            }
            else
            {
                replaced+=ch;
            }
        }
        Console.WriteLine(replaced);
    }
    public void combineBothWord(string firstWord,string secondWord)
    {
        string combined = firstWord+secondWord;
        combined = combined.ToUpper();
        int vowels =0 , consonants = 0;
        foreach(char ch in combined)
        {
            if(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                vowels++;
            }
            else
            {
                consonants++;
            }
        }
        if (vowels > consonants)
        {
            PrintFirstTwoDistinct(combined, "AEIOU");
        }
        else if (consonants > vowels)
        {
            PrintFirstTwoDistinct(combined, "BCDFGHJKLMNPQRSTVWXYZ");
        }
        else
        {
            Console.WriteLine("Vowels and consonants are equal");
        }
    }

    private void PrintFirstTwoDistinct(string word, string allowedChars)
    {
        HashSet<char> seen = new HashSet<char>();
        int count = 0;

        foreach (char ch in word)
        {
            if (allowedChars.Contains(ch) && !seen.Contains(ch))
            {
                Console.Write(ch);
                seen.Add(ch);
                count++;

                if (count == 2)
                    break;
            }
        }
    }

}