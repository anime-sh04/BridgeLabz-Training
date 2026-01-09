namespace ATM
{
    internal class AtmDispenser
    {
        void DispenseNotes(int amount)
        {
            int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int i = 0;
            while (amount != 0)
            {
                int count = amount / notes[i];
                if(count > 0)
                {
                    Console.WriteLine($"{count} note of {notes[i]} dispensed!");
                    amount = amount %notes[i];
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
			Console.WriteLine("Enter the amount you want to withdraw :");
            int amount = int.Parse(Console.ReadLine());
            if (amount == 0) 
            { 
                Console.WriteLine("Amount cant be 0"); 
                return; 
            }
            AtmDispenser atm = new AtmDispenser();
            atm.DispenseNotes(amount);
        }
    }
}
