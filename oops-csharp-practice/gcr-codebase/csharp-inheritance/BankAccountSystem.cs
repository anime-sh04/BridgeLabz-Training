using System;

class BankAccount{
    public int AccountNumber;
    public double Balance;

    public BankAccount(int accNo, double balance){
        AccountNumber = accNo;
        Balance = balance;
    }

    public void ShowAccount(){
        Console.WriteLine("Account Number:" + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}

class SavingsAccount: BankAccount{
    public double InterestRate;

    public SavingsAccount(int accNo,double balance,double interest)
        :base(accNo,balance){
        InterestRate = interest;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type: Savings Account");
        ShowAccount();
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount:BankAccount{
    public double WithdrawalLimit;

    public CheckingAccount(int accNo,double balance,double limit)
        :base(accNo,balance){
        WithdrawalLimit = limit;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type: Checking Account");
        ShowAccount();
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

class FixedDepositAccount :BankAccount{
    public int DepositYears;

    public FixedDepositAccount(int accNo,double balance,int years)
        :base(accNo,balance){
        DepositYears = years;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type:Fixed Deposit Account");
        ShowAccount();
        Console.WriteLine("Deposit Period: "+DepositYears + "years");
    }
}

class BankAccountSystem{
    static void Main(string[] args){
        SavingsAccount s = new SavingsAccount(101,5000,4.5);
        CheckingAccount c = new CheckingAccount(102,8000,2000);
        FixedDepositAccount f = new FixedDepositAccount(103,20000,5);

        s.DisplayAccountType();
        Console.WriteLine();

        c.DisplayAccountType();
        Console.WriteLine();

        f.DisplayAccountType();
    }
}
