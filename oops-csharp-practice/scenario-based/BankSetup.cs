/*Bank Account Manager
1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
● Problem: Design a BankAccount class with:
● Fields/Properties: AccountNumber, Balance.
● Methods: Deposit(double), Withdraw(double), CheckBalance().
● Include logic to prevent overdraft.*/
using System;

class Bank{
    public static string BankName;
    public string IFSCCode;
    public string Branch;
    public string MinimumBalance;
    public string MaximumTransaction;

    public Bank(string bankName,string ifscCode,string branch,string minimumBalance,string maximumTransaction){
        BankName = bankName;
        this.IFSCCode = ifscCode;
        this.Branch = branch;
        this.MinimumBalance = minimumBalance;
        this.MaximumTransaction = maximumTransaction;
    }

    public void DisplayDetails(){
        Console.WriteLine("Bank name : " + BankName);
        Console.WriteLine("IFSC Code : " + IFSCCode);
        Console.WriteLine("Branch Name : " + Branch);
        Console.WriteLine("MinimumBalance : " + MinimumBalance);
        Console.WriteLine("MaximumTransaction : " + MaximumTransaction);
    }
}

class User{
    private string AccountNumber;
    private string UserName;
    private double CurrentBalance;
    private double LastDeposittedAmount;
    private double LastWithDrawalAmount;

    public User(string accountNumber,string username,double currentbalance){
        AccountNumber = accountNumber;
        UserName = username;
        CurrentBalance = currentbalance;
    }

    public double Withdraw(bool manager,double amount=0){
        if(manager){
            return LastWithDrawalAmount;
        }

        if(amount > CurrentBalance){
            Console.WriteLine("Insufficient Balance");
            return 0;
        }

        LastWithDrawalAmount = amount;
        CurrentBalance -= amount;
        return CurrentBalance;
    }

    public double Deposit(bool manager,double amount=0){
        if(manager){
            return LastDeposittedAmount;
        }

        LastDeposittedAmount = amount;
        CurrentBalance += amount;
        return CurrentBalance;
    }

    public double GetBalance(){
        return CurrentBalance;
    }
}

class AccountManager{
    User user;

    public AccountManager(User u){
        user = u;
    }

    public void GetDeposit(){
        Console.WriteLine("Last Deposit: " + user.Deposit(true));
    }

    public void GetWithdrawal(){
        Console.WriteLine("Last Withdrawal: " + user.Withdraw(true));
    }

    public void CheckUserBalance(){
        Console.WriteLine("User Balance: " + user.GetBalance());
    }
}

class BankSetup{
    static void Main(){
        new BankSetup().Menu();
    }

    void Menu(){
        Bank bank = new Bank("SBI","SBIN03","Mathura","1000.25","50000");
        User user = new User("12345678","Animesh",125.47);
        AccountManager acc = new AccountManager(user);

        while(true){
            Console.WriteLine("\n1. Manager");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Show Bank Details");
            Console.WriteLine("4. Exit");

            int n = int.Parse(Console.ReadLine());

            switch(n){
                case 1:
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    if(password == "animesh019"){
                        while(true){
                            Console.WriteLine("\n1. Last Deposit");
                            Console.WriteLine("2. Last Withdrawal");
                            Console.WriteLine("3. Check User Balance");
                            Console.WriteLine("4. Back");

                            int choice = int.Parse(Console.ReadLine());

                            if(choice == 4) 
								break;

                            switch(choice){
                                case 1: 
									acc.GetDeposit(); 
									break;
                                case 2: 
									acc.GetWithdrawal(); 
									break;
                                case 3: 
									acc.CheckUserBalance(); 
									break;
                                default: 
									Console.WriteLine("Invalid Choice"); 
									break;
                            }
                        }
                    }
                    else{
                        Console.WriteLine("Wrong Password");
                    }
                    break;

                case 2:
                    while(true){
                        Console.WriteLine("\n1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Check Balance");
                        Console.WriteLine("4. Back");

                        int choice = int.Parse(Console.ReadLine());
                        if(choice == 4) break;

                        switch(choice){
                            case 1:
                                Console.Write("Enter amount: ");
                                double d = double.Parse(Console.ReadLine());
                                user.Deposit(false,d);
                                break;

                            case 2:
                                Console.Write("Enter amount: ");
                                double w = double.Parse(Console.ReadLine());
                                user.Withdraw(false,w);
                                break;

                            case 3:
                                Console.WriteLine("Balance: " + user.GetBalance());
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    break;

                case 3:
                    bank.DisplayDetails();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid Option");
					
                    break;
            }
        }
    }
}