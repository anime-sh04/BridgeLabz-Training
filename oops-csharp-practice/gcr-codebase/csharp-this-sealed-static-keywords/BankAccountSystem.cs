using System;

class Bank{
	static string bankName = "GLABank";
	private readonly long AccountNumber;
	private string AccountHolderName;
	
	private static long NumberOfAccounts=0;
	
	public Bank(long accountnumber, string accountholdername){
		this.AccountNumber = accountnumber;
		this.AccountHolderName = accountholdername;
		NumberOfAccounts++;
		
	}
	
	public void DisplayBankDetails(){
		//AccountNumber = 12345432234541; //readonly cannot be changed
		Console.WriteLine("Bank Name : " + bankName);
		Console.WriteLine("Account Holder Name : " +AccountHolderName);
		Console.WriteLine("Account Number : " + AccountNumber);
	}
	
	
	public static void GetTotalAccounts(){
		Console.WriteLine("Total Accounts in "+bankName+" are : " + NumberOfAccounts);
	}
}

class BankAccountSystem{
	static void Main(string[] args){
		Bank b1 = new Bank(123443234566, "Animesh");
		Bank b2 = new Bank(345677654345, "ARF");
		Bank b3 = new Bank(98765498765, "PAknwk");
		
		if(b1 is Bank)
			Console.WriteLine("Yes its from bankaccount class");
		else
			Console.WriteLine("No its not from bankaccount class");
		
		b1.DisplayBankDetails();
		b2.DisplayBankDetails();
		b3.DisplayBankDetails();
		Bank.GetTotalAccounts();
	}
}
