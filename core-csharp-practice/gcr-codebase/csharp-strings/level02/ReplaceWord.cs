using System;

class ReplaceWord{
    public static string Replace(string s, string word,string replaceWith){
        string newString = "";
        int i = 0;

        while (i<= s.Length -word.Length){
            string temp = s.Substring(i,word.Length);
            if(temp == word){
                newString += replaceWith;
                i += word.Length;
            }
            else{
                newString += s[i];
                i++;
            }
        }

        while (i <s.Length){
            newString += s[i];
            i++;
        }
		
        return newString;
    }

    static void Main(){
        string s = Console.ReadLine();
        string word = Console.ReadLine();
        string replaceWith = Console.ReadLine();

        Console.WriteLine("After Replacing : " + Replace(s,word,replaceWith));
    }
}
