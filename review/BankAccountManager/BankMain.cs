

/*Methods – Bank Account Manager
1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
● Problem: Design a BankAccount class with :
● Fields/Properties: AccountNumber, Balance.
● Methods: Deposit(double), Withdraw(double), CheckBalance().
● Include logic to prevent overdraft.*/

namespace review3
{
    class BankMain
    {
        public static void Main()
        {
            BankManager m = new BankManager();
            m.menu();
        }
    }
}
