using System;


class UniversityCourse{
	static void Main(string[] args){
		int fee = 125000;
		int discountPercent = 10;
		int discount = (fee*discountPercent)/100;
		
		int finalDiscountedFee = fee - discount;
		
		Console.WriteLine("The discount amount is INR " + discount+ " and final discounted fee is INR " + finalDiscountedFee);
	}
}
