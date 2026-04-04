namespace Sorting
{
    class AadharMenu
    {
        ICard card = new AadharUtilityImpl();
        public void Menu()
        {
            long[] cards ={664771035057,657455678902,887542890987,134215986123,980765435678};

            int n = cards.Length;
            int choice = 0;
            do{
                Console.WriteLine("1. Sort the Aadhar Cards");
                Console.WriteLine("2. Find a Aadhar Card");
                Console.WriteLine("0. Exit");

                choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                    card.SortAadhar(cards,n);
                else if(choice == 2)
                    card.FindAadhar(cards,n);
            }
            while(choice !=0);
        }
    }
}