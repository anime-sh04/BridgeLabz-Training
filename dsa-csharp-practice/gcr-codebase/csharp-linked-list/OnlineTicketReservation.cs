using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class TicketNode
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public string BookingTime;

    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, string seat, string time)
    {
        TicketID = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = time;
    }
}

class TicketSystem
{
    private TicketNode head = null;

    // Add ticket at end
    public void BookTicket(int id, string customer, string movie, string seat, string time)
    {
        TicketNode newNode = new TicketNode(id, customer, movie, seat, time);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }

        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    // Remove ticket by ID
    public void CancelTicket(int id)
    {
        if (head == null) return;

        TicketNode curr = head, prev = null;

        do
        {
            if (curr.TicketID == id)
            {
                if (curr == head)
                {
                    TicketNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    if (curr.Next == head)
                        head = null;
                    else
                    {
                        head = curr.Next;
                        last.Next = head;
                    }
                }
                else
                    prev.Next = curr.Next;

                Console.WriteLine("Ticket cancelled successfully.");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);

        Console.WriteLine("Ticket not found.");
    }

    // Display all tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode temp = head;
        Console.WriteLine("\nBooked Tickets:");

        do
        {
            Console.WriteLine($"ID:{temp.TicketID}  Customer:{temp.CustomerName}  Movie:{temp.MovieName}  Seat:{temp.SeatNumber}  Time:{temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    // Search ticket
    public void Search(string customer = "", string movie = "")
    {
        if (head == null) return;

        TicketNode temp = head;
        bool found = false;

        do
        {
            if ((customer != "" && temp.CustomerName == customer) ||
                (movie != "" && temp.MovieName == movie))
            {
                Console.WriteLine($"ID:{temp.TicketID}  Customer:{temp.CustomerName}  Movie:{temp.MovieName}  Seat:{temp.SeatNumber}  Time:{temp.BookingTime}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No matching ticket found.");
    }

    // Count tickets
    public void CountTickets()
    {
        if (head == null)
        {
            Console.WriteLine("Total Tickets: 0");
            return;
        }

        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Total Tickets: " + count);
    }
}

class Program
{
    static void Main()
    {
        TicketSystem system = new TicketSystem();

        system.BookTicket(1, "Animesh", "Inception", "A1", "10:30 AM");
        system.BookTicket(2, "Ravi", "Interstellar", "B2", "11:00 AM");
        system.BookTicket(3, "Neha", "Inception", "C3", "12:00 PM");

        system.DisplayTickets();
        system.CountTickets();

        Console.WriteLine("\nSearch Movie: Inception");
        system.Search(movie: "Inception");

        system.CancelTicket(2);

        system.DisplayTickets();
        system.CountTickets();
    }
}

