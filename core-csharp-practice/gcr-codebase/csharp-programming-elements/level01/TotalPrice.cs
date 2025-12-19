using System;

class TotalPrice{
	static void Main(string[] args){
		double unitPrice = Convert.ToDouble(Console.ReadLine());
		double quantity = Convert.ToDouble(Console.ReadLine());
		
		double total = unitPrice*quantity;
		
		Console.WriteLine("The total purchase price is INR "+total+" if the quantity "+quantity+ " and unit price is INR " +unitPrice);
	}
}
