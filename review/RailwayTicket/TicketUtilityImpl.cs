class TicketUtilityImpl : ITicket
{
    private Ticket[] confirmed = new Ticket[2];
    private Passenger[] waiting =new Passenger[100];
    private int confirmedCount=0;
    private int waitingCount =0;
    private int ticketCounter = 1;
    public void AddTicket(Passenger p)
    {
        if (confirmedCount< confirmed.Length)
        {
            Console.WriteLine($"Confirmed ticket for {p.Name}, your ticket id is {ticketCounter}");
            confirmed[confirmedCount++] = new Ticket(ticketCounter++, p);
        }
        else
        {
            // Console.WriteLine($"{p.Name} added to waiting list and your ticket id is {ticketCounter}");
            waiting[waitingCount++] = p;
            SortWaitingByPriority();
        }
    }
    public void CancelTicket(int ticketId)
    {
        for (int i = 0; i < confirmedCount; i++)
        {
            if (confirmed[i].Id == ticketId)
            {
                Console.WriteLine($"Ticket cancelled for {confirmed[i].Passenger.Name}");
                for (int j=i; j <confirmedCount-1; j++)
                {
                    confirmed[j] = confirmed[j+1];
                }

                confirmed[--confirmedCount] = null;
                PromoteFromWaiting();
                return;
            }
        }
        Console.WriteLine("Ticket not found");
    }
    public void SortWaitingByPriority()
    {
        for (int i = 0; i < waitingCount -1; i++){
            for (int j = 0; j < waitingCount- i-1; j++){
                // if(!waiting[j].IsSenior() && waiting[j+1].IsSenior())
                if(waiting[j].Age <waiting[j+1].Age)
                {
                    Passenger temp = waiting[j];
                    waiting[j] = waiting[j+1];
                    waiting[j + 1] = temp;
                }
            }
        }
    }
    public void PromoteFromWaiting()
    {
        if (waitingCount == 0)
        {
            return;
        }

        Passenger p = waiting[0];
        for (int i = 0; i <waitingCount-1; i++)
            waiting[i] = waiting[i+1];

        waiting[--waitingCount] =null;

        confirmed[confirmedCount++] = new Ticket(ticketCounter++, p);
        Console.WriteLine($"Promoted {p.Name} from waiting list");
    }
}

