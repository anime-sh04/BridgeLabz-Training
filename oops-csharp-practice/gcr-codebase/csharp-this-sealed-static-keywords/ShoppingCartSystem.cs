using System;

class Product{
    static double Discount = 5;

    private readonly int ProductID;
    private string ProductName;
    private double Price;
    private int Quantity;

    public Product(int productid, string productname, double price, int quantity){
        this.ProductID = productid;
        this.ProductName = productname;
        this.Price = price;
        this.Quantity = quantity;
    }

    public void DisplayProductDetails(){
        Console.WriteLine("Product ID : " +ProductID);
        Console.WriteLine("Product Name : "+ ProductName);
        Console.WriteLine("Price : " +Price);
        Console.WriteLine("Quantity : "+ Quantity);
        Console.WriteLine("Discount : " +Discount + "%");
    }

    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
    }
}

class ShoppingCartSystem{
    static void Main(string[] args){
        Product p1 = new Product(201, "Phone",20000, 5);
        Product p2 = new Product(202,"Headphones",3000,2);

        Product.UpdateDiscount(10);

        if(p1 is Product)
            Console.WriteLine("Yes its from Product class");
        else
            Console.WriteLine("No its not from Product class");

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
    }
}
