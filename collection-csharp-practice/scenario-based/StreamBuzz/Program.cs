class Program
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
    public int count =0;
    static void Main()
    {
        Program m = new Program();
        
        while (true)
        {
            Console.WriteLine("1. Registor Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 4)
            {
                Console.WriteLine("Logging off — Keep Creating with StreamBuzz!");
                return;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Creator Name : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter weekly likes (Week 1 to 4): ");
                    double[] temp = new double[4];
                    for(int i = 0; i < 4; i++)
                    {
                        temp[i] = double.Parse(Console.ReadLine());
                    }
                    m.RegisterCreator(new CreatorStats(name,temp));
                    break;
                case 2:
                    Console.WriteLine("Enter Like Threshold : ");
                    int likeThreshold = int.Parse(Console.ReadLine());
                    Dictionary<string,int> toppost = m.GetTopPostCounts(EngagementBoard,likeThreshold);
                    if(toppost.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach(var kvp in toppost)
                        {
                            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                        }
                    }
                    break;
                case 3:
                    double average = m.CalculateAverageLikes();
                    Console.WriteLine("Overall average weekly likes : "+ average);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
        Console.WriteLine("Creator registered Successfully");
    }
    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string,int> toppost = new Dictionary<string, int>();
        for(int i = 0; i < records.Count; i++)
        {
            int count =0;
            for(int j = 0; j < 4; j++)
            {
                if(records[i].WeeklyLikes[j] >= likeThreshold)
                {
                    toppost[records[i].CreatorName] = ++count;
                }
            }
            count =0;
        }
        return toppost;
    }
    public double CalculateAverageLikes()
    {
        double average =0;
        for(int i = 0; i < EngagementBoard.Count; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                average+=EngagementBoard[i].WeeklyLikes[j];
            }   
        }
        return average/(EngagementBoard.Count*4);
    }
}