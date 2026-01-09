using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class BookNode
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;

    public BookNode Prev;
    public BookNode Next;

    public BookNode(string title, string author, string genre, int id, bool available)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = id;
        IsAvailable = available;
    }
}

class Library
{
    private BookNode head;
    private BookNode tail;

    // Add at Beginning
    public void AddAtBeginning(string title, string author, string genre, int id, bool available)
    {
        BookNode newNode = new BookNode(title, author, genre, id, available);

        if (head == null)
            head = tail = newNode;
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }

    // Add at End
    public void AddAtEnd(string title, string author, string genre, int id, bool available)
    {
        BookNode newNode = new BookNode(title, author, genre, id, available);

        if (tail == null)
            head = tail = newNode;
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    // Add at Position
    public void AddAtPosition(int pos, string title, string author, string genre, int id, bool available)
    {
        if (pos <= 1)
        {
            AddAtBeginning(title, author, genre, id, available);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < pos - 1 && temp.Next != null; i++)
            temp = temp.Next;

        if (temp.Next == null)
        {
            AddAtEnd(title, author, genre, id, available);
            return;
        }

        BookNode newNode = new BookNode(title, author, genre, id, available);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }

    // Remove by Book ID
    public void Remove(int id)
    {
        BookNode temp = head;

        while (temp != null && temp.BookID != id)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp == head) head = temp.Next;
        if (temp == tail) tail = temp.Prev;

        if (temp.Prev != null) temp.Prev.Next = temp.Next;
        if (temp.Next != null) temp.Next.Prev = temp.Prev;

        Console.WriteLine("Book removed successfully.");
    }

    // Search
    public void Search(string title = "", string author = "")
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if ((title != "" && temp.Title == title) ||
                (author != "" && temp.Author == author))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No matching book found.");
    }

    // Update Availability
    public void UpdateAvailability(int id, bool status)
    {
        BookNode temp = head;

        while (temp != null && temp.BookID != id)
            temp = temp.Next;

        if (temp == null)
            Console.WriteLine("Book not found.");
        else
        {
            temp.IsAvailable = status;
            Console.WriteLine("Availability updated.");
        }
    }

    // Display Forward
    public void DisplayForward()
    {
        Console.WriteLine("\nLibrary (Forward):");
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    // Display Reverse
    public void DisplayReverse()
    {
        Console.WriteLine("\nLibrary (Reverse):");
        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    // Count Books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine("Total Books: " + count);
    }

    private void DisplayBook(BookNode b)
    {
        Console.WriteLine($"ID:{b.BookID}  Title:{b.Title}  Author:{b.Author}  Genre:{b.Genre}  Available:{b.IsAvailable}");
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();

        lib.AddAtEnd("Harry Potter", "Rowling", "Fantasy", 1, true);
        lib.AddAtBeginning("The Hobbit", "Tolkien", "Fantasy", 2, true);
        lib.AddAtEnd("1984", "Orwell", "Dystopian", 3, false);
        lib.AddAtPosition(2, "Dune", "Herbert", "Sci-Fi", 4, true);

        lib.DisplayForward();
        lib.DisplayReverse();

        Console.WriteLine("\nSearch by Author: Tolkien");
        lib.Search(author: "Tolkien");

        lib.UpdateAvailability(3, true);
        lib.Remove(1);

        lib.DisplayForward();
        lib.CountBooks();
    }
}
