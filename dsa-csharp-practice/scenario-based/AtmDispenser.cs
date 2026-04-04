namespace ATM
{
    internal class AtmDispenser
    {
        void DispenseNotes(int amount)
        {
            //int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };  // Scenario A with 500 note

            //int[] notes = {200, 100, 50, 20, 10, 5, 2, 1 };  // Scenario B without 500 note
            //int i = 0;
            //while (amount != 0)
            //{
            //    int count = amount / notes[i];
            //    if(count > 0)
            //    {
            //        Console.WriteLine($"{count} note of {notes[i]} dispensed!");
            //        amount = amount %notes[i];
            //    }
            //    i++;
            //}
            int[] notes = { 200, 100, 50 }; // Scenario C - Lets assume we only have these notes
            int despenseAmount = 0;
            for(int i=0; i<notes.Length; i++)
            {
                int count = amount / notes[i];
                if (count > 0)
                {
                    despenseAmount += count * notes[i];
                    amount -= count * notes[i];
                }
            }
            Console.WriteLine($"Sorry! Only {despenseAmount} amount can be withdrawn,we dont have changes");
        }
        static void Main(string[] args)
        {
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
