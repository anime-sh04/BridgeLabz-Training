class VesselUtil
{
    private List<Vessel> vesselList = new List<Vessel>();
    public void addVesselPerformance(Vessel vessel)
    {
        vesselList.Add(vessel);
        Console.WriteLine("Vessel Added Successfully");
    }
    public Vessel GetVesselById(string VesselId)
    {
        for(int i = 0; i < vesselList.Count; i++)
        {
            if (vesselList[i].vesselId.Equals(VesselId))
            {
                return vesselList[i];
            }
        }
        Console.WriteLine("Vessel not found!");
        return null;
    }
    public List<Vessel> getHighPerformanceVessels()
    {
        List<Vessel> highPerformance = new List<Vessel>();
        double maxSpeed = 0.0;
        for (int i= 0; i <vesselList.Count;i++)
        {
            if (vesselList[i].averageSpeed > maxSpeed)
            {
                maxSpeed = vesselList[i].averageSpeed;
            }
        }
        
        for (int i = 0; i<vesselList.Count; i++)
        {
            if (vesselList[i].averageSpeed == maxSpeed)
            {
                highPerformance.Add(vesselList[i]);
            }
        }

        return highPerformance;
    }

}