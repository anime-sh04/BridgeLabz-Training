class TicketMenu
{
    ITicket i = new TicketUtilityImpl();
    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. Cancel Ticket");
            Console.WriteLine("0. Exit");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0) return;

            if(choice == 1)
            {
                Console.WriteLine("Enter Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age : ");
                int age = int.Parse(Console.ReadLine());
                i.AddTicket(new Passenger(name,age));
            }
            if(choice == 2)
            {
                Console.WriteLine("Enter Ticket ID : ");
                int ticketId = int.Parse(Console.ReadLine());
                i.CancelTicket(ticketId);
            }
        }
    }

}