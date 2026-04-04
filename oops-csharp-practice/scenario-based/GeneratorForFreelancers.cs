/*Invoice Generator for Freelancers
Focus: Strings, Methods
● Scenario: You're building an app for freelancers to generate invoice descriptions.
 Requirements:
● Accept input like: "Logo Design - 3000 INR, Web Page - 4500 INR".
● Split the string to extract task names and amounts.
● Calculate total invoice amount.
● Example Methods:
● splitcomma(string input)
● TotalSum(string[] tasks)*/

using System;


class GeneratorForFreelancers{
    static void Main(){
        Console.WriteLine("Enter invoice details:");
        string input = Console.ReadLine();
		GeneratorForFreelancers obj = new GeneratorForFreelancers();

        string[] tasks = obj.splitcomma(input);

        Console.WriteLine("Invoice:");
        foreach(string t in tasks){
            Console.WriteLine(t.Trim());
        }

        int total = obj.TotalSum(tasks);
        Console.WriteLine("Total Amount = " + total);
    }
	
    public string[] splitcomma(string input){
        string[] tasks = input.Split(',');
        return tasks;
    }

    public int TotalSum(string[] tasks){
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
