using System;

class SplitText
{
    public static int GetLength(string s){
        int count = 0;
        foreach (char ch in s)
            count++;

        return count;
    }
    public static string[,] Splitter(string text){
        int count = 1;
        foreach(char ch in text)
            if(ch == ' ')
				count++;

        string[,] arr = new string[count, 2];

        string temp = "";
        int idx = 0;

        foreach (char ch in text){
            if (ch == ' '){
                arr[idx, 0] = temp;
                arr[idx, 1] = GetLength(temp).ToString();
                temp = "";
                idx++;
            }
            else{
                temp += ch;
            }
        }
        arr[idx, 0] = temp;
        arr[idx, 1] = GetLength(temp).ToString();

        return arr;
    }

    static void Main(){
        string s = Console.ReadLine();
        string[,] arr = Splitter(s);

        for (int i=0;i<arr.GetLength(0);i++){
            Console.WriteLine(arr[i,0] + " " + arr[i,1]);
        }
    }
}
