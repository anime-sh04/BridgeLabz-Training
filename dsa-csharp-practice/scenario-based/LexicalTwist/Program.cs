class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first word : ");
        string firstWord = Console.ReadLine();

        Console.WriteLine("Enter second word : ");
        string secondWord = Console.ReadLine();
        if (firstWord.Contains(" "))
        {
            Console.WriteLine(firstWord + " is an invalid word");
            return;
        }
        if (secondWord.Contains(" "))
        {
            Console.WriteLine(secondWord + " is an invalid word");
            return;
        }

        LexicalUtil util = new LexicalUtil();
        util.isReversed(firstWord, secondWord);
    }
}
