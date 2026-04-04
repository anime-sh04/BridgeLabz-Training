class TimberTransport : GoodsTransport
{
    public float timberLength{get;set;}
    public float timberRadius{get;set;}
    public string timberType{get;set;}
    public float timberPrice{get;set;}
    public TimberTransport(string transportId,string transportDate,int transportRating,float length,float radius,string type,float price) : base(transportId, transportDate, transportRating)
    {
        timberLength = length;
        timberRadius = radius;
        timberType = type;
        timberPrice = price;
    }
    public override string vehicleSelection()
    {
        double area = 2*3.147*timberRadius*timberLength;
        if(area < 250)
        {
            return "Truck";
        }
        else if(area >= 250 && area <= 400)
        {
            return "Lorry";
        }
        else
        {
            return "MonsterLorry";
        }
    }

    public override float calculateTotalCharge()
    {
        
        double volume = 3.147*timberRadius*timberRadius*timberLength;
        double premium = 0.0;
        if (timberType.Equals("Premium"))
        {
            premium = 0.25;
        }
        else
        {
            premium = 0.15;
        }
        double price = volume*timberPrice*premium;
        double tax = price*0.3;
        float discountPercentage = calculateDiscount();
        double discount = price *discountPercentage/100;
        string vehicle = vehicleSelection();
        int vehiclePrice =0;
        if (vehicle.Equals("Truck"))
        {
            vehiclePrice = 1000;
        }
        else if (vehicle.Equals("Lorry"))
        {
            vehiclePrice = 1700;
        }
        else
        {
            vehiclePrice = 3000;
        }
        double totalCharge = price + vehiclePrice+tax - discount;
        return (float)totalCharge; 
    }
}