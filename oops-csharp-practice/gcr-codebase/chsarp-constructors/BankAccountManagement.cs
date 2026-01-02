using System;

class BankAccount{
	public long accountNumber;
	protected string accountHolder;
	private double balance;
	
	public BankAccount(long accountNumber,string accountHolder,double balance){
		this.accountNumber= accountNumber;
		this.accountHolder = accountHolder;
		this.balance = balance;
	}
	
	public void ModifyBalance(double newbalance){
		balance = newbalance;
	}
	public void AccessBalance(){
		Console.WriteLine(balance);
	}
}

class SavingAccount : BankAccount{
	public SavingAccount(long accountNumber,string accountHolder,double balance):base(accountNumber,accountHolder,balance){}
	
	public void DisplayAccountInfo(){
        Console.WriteLine("Account Number : " + accountNumber);   // public
        Console.WriteLine("Account Holder : " + accountHolder);   // protected
    }
}

class BankAccountManagement{
	static void Main(string[] args){
		SavingAccount s1= new SavingAccount(234234123452345,"Animesh",241.12);
	    s1.DisplayAccountInfo();
		s1.AccessBalance();
		s1.ModifyBalance(1242.1);
		s1.AccessBalance();
	}
}
