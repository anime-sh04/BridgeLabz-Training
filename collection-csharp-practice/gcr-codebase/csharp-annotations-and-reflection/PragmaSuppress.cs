using System.Collections;

class PragmaSuppress
{
    static void Main()
    {
        #pragma warning disable CS0618
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("HI");
        list.Add(20);
        
        #pragma warning restore CS0618
        foreach(var item in list)
        {
            Console.Write($"{item} ,");
        }
    }
}