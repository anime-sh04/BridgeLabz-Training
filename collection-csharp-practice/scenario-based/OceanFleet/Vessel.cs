class Vessel
{
    public string vesselId{get ; set;}
    public string vesselName{get ; set;}
    public double averageSpeed{get ; set;}
    public string vesselType{get ; set;}
    public Vessel(string id,string name,double speed,string type)
    {
        vesselId = id;
        vesselName = name;
        averageSpeed = speed;
        vesselType = type;
    } 
}