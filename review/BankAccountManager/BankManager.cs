using review3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    class BankManager
    {
        User user;
        IAccount account;

        public void menu()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            user = new User(name);
            account = new BankAccount("A101", 1000, user);

            while (true)
            {
                Console.WriteLine("\n1. User");
                Console.WriteLine("2. Manager");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 3) 
                    break;


                if (choice == 1)
                    UserMenu();
                else
                    ManagerMenu();
            }
        }

        void UserMenu()
        {
            Console.WriteLine("User Menu\n");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");

            int choice2 = int.Parse(Console.ReadLine());

            if (choice2 == 1)
            {
                Console.WriteLine("Enter the amount you want to desposit");
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);
            }
            else if (choice2 == 2)
            {
                Console.WriteLine("Enter the amount you want to withdraw");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
            else
                Console.WriteLine("Current Balance: " + account.CheckBalance());
        }

        void ManagerMenu()
        {
            Console.WriteLine("Enter Manager Password");
            string password = Console.ReadLine();

            if(password != "1234")
            {
                Console.WriteLine("Wrong Password");
                return;
            }
            Console.WriteLine("\nManager View");
            Console.WriteLine("User: " + user.Name);
            Console.WriteLine("Account No: A101");
            Console.WriteLine("Balance: " + account.CheckBalance());
        }
    }
}

