using System;


class UniversityCourse{
	static void Main(string[] args){
		int fee = Convert.ToInt32(Console.ReadLine());
		int discountPercent = Convert.ToInt32(Console.ReadLine());
		int discount = (fee*discountPercent)/100;;
		
		int finalDiscountedFee = fee - discount;
		
		Console.WriteLine("The discount amount is INR " + discount+ " and final discounted fee is INR " + finalDiscountedFee);
	}
}
