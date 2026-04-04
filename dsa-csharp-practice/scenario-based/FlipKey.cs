class FlipKey
{
    static void Main()
    {
        FlipKey p = new FlipKey();
        Console.WriteLine("Enter the word ");
        string word = Console.ReadLine();
        string key = p.CleanseAndInvert(word);
        if(key == "")
            Console.WriteLine("Invalid Input");
        else
            Console.WriteLine(key);

    }
    public string CleanseAndInvert(string input)
    {
        if(input == null || input.Length<6)
            return "";

        foreach (char ch in input)
        {
            if (!char.IsLetter(ch))
                return "";
        }

        string lowercase = input.ToLower();
        string afterRemovingEvenAscii ="";
        foreach(char ch in lowercase)
        {
            if((int)ch % 2 == 0)
            {
                continue;
            }
            else
                afterRemovingEvenAscii += ch;
        }
        string reverse ="";
        for(int i= afterRemovingEvenAscii.Length - 1; i >= 0; i--)
        {
            reverse+= afterRemovingEvenAscii[i];
        }
        string final ="";
        int j=0;
        foreach(char ch in reverse)
        {
            if(j%2 == 0)
            {
                final += Char.ToUpper(ch);
            }
            else
            {
                final +=ch;
            }
            j++;
        }
        return final;
    }
}