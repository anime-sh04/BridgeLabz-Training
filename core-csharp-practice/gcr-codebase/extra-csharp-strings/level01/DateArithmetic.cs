using System;
using System.Globalization;


class DateArithmetic{
	static void Main(string[] args){
		string input = Console.ReadLine();
		
		DateTime date =DateTime.ParseExact(input , "dd-MM-yyyy", CultureInfo.InvariantCulture);
		date = date.AddDays(7);
		date = date.AddMonths(1);
		date = date.AddYears(2);
		
		DateTime result = date.AddDays(-7*3);
		Console.WriteLine(result);
	}
}