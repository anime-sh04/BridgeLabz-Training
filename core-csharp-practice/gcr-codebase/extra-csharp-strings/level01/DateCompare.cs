using System;
using System.Globalization;

class DateCompare{
    static void Main(){
        Console.WriteLine("Enter first date (dd-MM-yyyy): ");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Enter second date (dd-MM-yyyy): ");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

        int result = DateTime.Compare(date1, date2);

        if (result<0){
            Console.WriteLine("First date is before the second date");
        }
        else if (result>0){
            Console.WriteLine("First date is after the second date");
        }
        else{
            Console.WriteLine("Both dates are the same");
        }
    }
}
