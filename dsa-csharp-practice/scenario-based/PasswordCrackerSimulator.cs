using System;

namespace PasswordCracker
{

    class PasswordCrackerSimulator
    {
        static void Main(string[] args)
        {
            int n = 4;
            PasswordCrackerSimulator p = new PasswordCrackerSimulator();
            Console.WriteLine("Enter your password (Only characters 4 digits)");
            string password = Console.ReadLine();
            string result = p.Backtrack(n, "",password);
            if(result == "")
                Console.WriteLine("Not Found");
            else
                Console.WriteLine($"\n\nPassword Cracked: {result}");
        }

        string Backtrack(int n, string word,string password)
        {
            if (word == password)
                return word;
                
            if (word.Length == n){
                Console.Write($"{word},");
                return "";}

            char[] characters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            Console.Write($"{word},");

            foreach(char c in characters)
            {
                string result = Backtrack(n, word + c,password);
                if (result != "")
                    return result;
            }

            return "";
        }
    }
}
