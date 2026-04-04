using System;

class ProfitAndProfitPercentage {
    static void Main(string[] args) {
        int sellingPrice = 191;
        int costPrice = 129;

        int profit = sellingPrice - costPrice;
        double profitPercentage = (double)profit / costPrice * 100;

        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice);
        Console.WriteLine("The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage);
    }
}
