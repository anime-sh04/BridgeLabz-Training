using review3;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    class BankAccount : IAccount
    {
        public string AccountNumber;
        public User Owner;
        private double Balance;

        public BankAccount(string accNo, double balance, User user)
        {
            AccountNumber = accNo;
            Balance = balance;
            Owner = user;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Amount Deposited, Total Balance : "+Balance);
        }

        public void Withdraw(double amount)
        {
            if (amount >Balance)
                Console.WriteLine("Insufficient Balancen,OVERDRAFT");
            else
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn, Balance Left : "+Balance);
            }
        }

        public double CheckBalance()
        {
            return Balance;
        }
    }
}
