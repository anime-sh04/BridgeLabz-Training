using System;

class Order{
    protected int OrderId;
    protected string OrderDate;

    public Order(int id,string date){
        OrderId = id;
        OrderDate = date;
    }

    public virtual string GetOrderStatus(){
        return "Order Placed";
    }
}

class ShippedOrder:Order{
    protected string TrackingNumber;

    public ShippedOrder(int id,string date,string tracking): base(id,date){
        TrackingNumber = tracking;
    }

    public override string GetOrderStatus(){
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder{
    string DeliveryDate;

    public DeliveredOrder(int id,string date,string tracking, string delivery) :base(id,date,tracking){
        DeliveryDate =delivery;
    }

    public override string GetOrderStatus(){
        return "Order Delivered on " + DeliveryDate;
    }
}

class OnlineRetailOrderManagement{
    static void Main(string[] args){
        DeliveredOrder d = new DeliveredOrder(101,"1-Jan","TRK889","5-Jan");
        Console.WriteLine(d.GetOrderStatus());
    }
}
