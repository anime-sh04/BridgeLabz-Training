using System;

class Product{
	private string ProductName;
	private double price;
	
	static int totalProducts=0;
	
	public Product(string productname,double price){
		this.ProductName = productname;
		this.price = price;
		totalProducts++;
	}
	
	public void DisplayProductDetails(){
		Console.WriteLine("Product Name : "+ProductName);
		Console.WriteLine("Product Price : "+price);
	}
	
	public static void DisplayTotalProducts(){
		Console.WriteLine("Total Products : "+totalProducts);
	}
}

class ProductInventory{
	static void Main(string[] args){
		Product p1 = new Product("Samsung",12343);
		Product p2 = new Product("Apple",2841);
		
		p1.DisplayProductDetails();
		p2.DisplayProductDetails();
		
		Product.DisplayTotalProducts();
	}
}
