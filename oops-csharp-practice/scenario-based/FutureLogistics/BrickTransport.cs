class BrickTransport : GoodsTransport
{
    public float brickSize {get;set;}
    public int brickQuantity {get;set;}
    public float brickPrice{get;set;}

    public BrickTransport(string transportId,string transportDate,int transportRating,float size,int quantity,float price) : base(transportId, transportDate, transportRating)
    {
        brickPrice = price;
        brickQuantity = quantity;
        brickSize = size;
    }

    public override string vehicleSelection()
    {
        if (brickQuantity < 300)
        {
            return "Truck";
        }
        else if (brickQuantity >= 300 && brickQuantity <=500)
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
        float price = brickPrice*brickQuantity;
        double tax = price*0.3;
        float discountPercentage = calculateDiscount();
        double discount = price*discountPercentage/100;
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