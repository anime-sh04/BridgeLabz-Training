using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Encapsulation
{
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        protected double Balance { get { return balance; } }

        public BankAccount(string accNo, string name, double initialBalance)
        {
            accountNumber = accNo;
            holderName = name;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public abstract double CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine("\nAccount No : " + AccountNumber);
            Console.WriteLine("Holder : " + HolderName);
            Console.WriteLine("Balance : " + Balance);
        }
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accNo, string name, double balance)
            : base(accNo, name, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.04;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine("Loan applied for amount: " + amount);
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5; 
        }
    }

    class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accNo, string name, double balance)
            : base(accNo, name, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.01;
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount[] accounts = new BankAccount[2];

            accounts[0] = new SavingsAccount("SBIA", "Animesh", 5000);
            accounts[1] = new CurrentAccount("CA202", "Rahul", 80000);

            for (int i = 0; i < accounts.Length; i++)
            {
                BankAccount acc = accounts[i];

                acc.DisplayDetails();
                Console.WriteLine("Interest :" +acc.CalculateInterest());

                if (acc is ILoanable)
                {
                    ILoanable loanAcc = (ILoanable)acc;
                    loanAcc.ApplyForLoan(100000);
                    Console.WriteLine("Loan Eligibility : " +loanAcc.CalculateLoanEligibility());
                }
            }
        }
    }
}
