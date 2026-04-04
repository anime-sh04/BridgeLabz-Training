abstract class GoodsTransport
{
    public string transportId {get ; set;}
    public string transportDate {get; set;}
    public int transportRating {get; set;}
    public GoodsTransport(string id, string date,int  rating)
    {
        transportId = id;
        transportDate =date;
        transportRating = rating;   
    }
    abstract public string vehicleSelection();
    abstract public float calculateTotalCharge();
    public float calculateDiscount()
    {
        if(transportRating == 5)
        {
            return 20;
        }
        else if(transportRating >= 3 && transportRating <= 4)
        {
            return 10;
        }
        else
        {
            return 0;
        }
    }
}