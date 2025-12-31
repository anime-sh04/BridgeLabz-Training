/*Invoice Generator for Freelancers
Focus: Strings, Methods
● Scenario: You're building an app for freelancers to generate invoice descriptions.
 Requirements:
● Accept input like: "Logo Design - 3000 INR, Web Page - 4500 INR".
● Split the string to extract task names and amounts.
● Calculate total invoice amount.
● Example Methods:
● ParseInvoice(string input)
● GetTotalAmount(string[] tasks)*/

using System;


class GeneratorForFreelancers{
    static void Main(){
        Console.WriteLine("Enter invoice details:");
        string input = Console.ReadLine();
		GeneratorForFreelancers obj = new GeneratorForFreelancers();

        string[] tasks = obj.ParseInvoice(input);

        Console.WriteLine("Invoice Details:");
        foreach(string t in tasks){
            Console.WriteLine(t.Trim());
        }

        int total = obj.GetTotalAmount(tasks);
        Console.WriteLine("Total Invoice Amount = " + total);
    }
	
    public string[] ParseInvoice(string input){
        string[] tasks = input.Split(',');
        return tasks;
    }

    public int GetTotalAmount(string[] tasks){
        int total = 0;

        foreach(string task in tasks){
            string[] parts = task.Split('-');
			/* Console.WriteLine("\nParts"); */
			/* foreach(string i in parts)
				Console.WriteLine(i); */
			/* Console.WriteLine("\nAmountParts"); */
            string amountPart = parts[1].Trim();
			/* Console.WriteLine(amountPart); */
			
            string[] amountSplit = amountPart.Split(' ');
			/* Console.WriteLine("AmountSplit"); */
			/* foreach(string i in amountSplit)
				Console.WriteLine(i); */
			
            int amount = int.Parse(amountSplit[0]);

            total += amount;
        }

        return total;
    }
}
