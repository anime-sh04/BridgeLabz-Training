class Program
{
    static void Main(string[] args)
    {
        // ITicket i = new TicketUtilityImpl();

        // i.AddTicket(new Passenger("p1", 65)); 
        // i.AddTicket(new Passenger("p2", 30));
        // i.AddTicket(new Passenger("oldp3", 70));  
        // // i.AddTicket(new Passenger("p4", 25));
        // i.AddTicket(new Passenger("p5", 40));
        // i.AddTicket(new Passenger("oldp6", 80)); 
        // i.CancelTicket(2);
        // i.CancelTicket(1);
        TicketMenu menu = new TicketMenu();
        menu.Menu();
    }
}
