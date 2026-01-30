class UserInterface
{
    static void Main()
    {
        VesselUtil u = new VesselUtil();
        Console.WriteLine("Enter the number of vessels to be added ");
        int numberofVesselsToAdd = int.Parse(Console.ReadLine());
        string[] vessels = new string[numberofVesselsToAdd];
        for(int i = 0; i < numberofVesselsToAdd; i++)
        {
            vessels[i] = Console.ReadLine();
        }
        for(int i = 0; i < numberofVesselsToAdd; i++)
        {
            string[] parts = vessels[i].Split(':');
            u.addVesselPerformance(new Vessel(parts[0],parts[1],double.Parse(parts[2]),parts[3]));    
        }
        
        string id = Console.ReadLine();
        Vessel temp = u.GetVesselById(id);
        if (temp != null)
        {
            Console.WriteLine($"\n{temp.vesselId} | {temp.vesselName} | {temp.averageSpeed} | {temp.vesselType}");
        }
        else
        {
            Console.WriteLine($"Vessel Id {id} not found!");
        }
        List<Vessel> highPerformance = new List<Vessel>();
        highPerformance = u.getHighPerformanceVessels();
        Console.WriteLine("High Performing Vessels are : ");
        foreach (Vessel v in highPerformance)
        {
            Console.WriteLine($"\n{v.vesselId} | {v.vesselName} | {v.vesselType} | {v.averageSpeed} knots");
        }
    }
}