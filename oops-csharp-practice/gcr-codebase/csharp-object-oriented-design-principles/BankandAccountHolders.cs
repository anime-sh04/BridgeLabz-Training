using System;
using System.Collections.Generic;

class Account{
    public int AccountNumber;
    public double Balance;

    public Account(int accNo,double balance){
        AccountNumber = accNo;
        Balance = balance;
    }
}

class Customer{
    public string Name;
    private List<Account> accounts =new List<Account>();

    public Customer(string name){
        Name =name;
    }

    public void AddAccount(Account acc){
        accounts.Add(acc);
    }

    public void ViewBalance(){
        Console.WriteLine("Customer: " + Name);
        foreach(Account acc in accounts){
            Console.WriteLine("Account " +acc.AccountNumber +"Balance: " +acc.Balance);
        }
        Console.WriteLine();
    }
}

class Bank{
    public string BankName;
    public Bank(string name){
        BankName= name;
    }

    public Account OpenAccount(Customer cust, int accNo, double balance){
        Account acc = new Account(accNo, balance);
        cust.AddAccount(acc);
        Console.WriteLine("Account created in"+ BankName+" for "+ cust.Name);
        return acc;
    }
}

class BankAndAccountHolders{
    static void Main(){
        Bank bank = new Bank("State Bank");

        Customer c1 = new Customer("Animesh");
        Customer c2 = new Customer("Awnai");

        bank.OpenAccount(c1,101,5000);
        bank.OpenAccount(c1,102,12000);
        bank.OpenAccount(c2,201,8000);

        c1.ViewBalance();
        c2.ViewBalance();
    }
}
