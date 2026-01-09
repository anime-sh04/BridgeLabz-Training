using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    public Movie Prev;
    public Movie Next;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newNode = new Movie(title, director, year, rating);

        if (head == null)
            head = tail = newNode;
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newNode = new Movie(title, director, year, rating);

        if (tail == null)
            head = tail = newNode;
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }
    public void AddAtPosition(int pos, string title, string director, int year, double rating)
    {
        if (pos <= 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        Movie temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null || temp.Next == null)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }

        Movie newNode = new Movie(title, director, year, rating);
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }

    public void RemoveByTitle(string title)
    {
        Movie temp = head;

        while (temp != null && temp.Title != title)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        if (temp == head)
            head = temp.Next;
        if (temp == tail)
            tail = temp.Prev;

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;

        Console.WriteLine("Movie removed successfully.");
    }

    public void Search(string director = "", double rating = -1)
    {
        Movie temp = head;
        bool found = false;

        while (temp != null)
        {
            if ((director != "" && temp.Director == director) ||
                (rating != -1 && temp.Rating == rating))
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No matching movie found.");
    }

    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;

        while (temp != null && temp.Title != title)
            temp = temp.Next;

        if (temp == null)
            Console.WriteLine("Movie not found.");
        else
        {
            temp.Rating = newRating;
            Console.WriteLine("Rating updated successfully.");
        }
    }
    public void DisplayForward()
    {
        Movie temp = head;
        Console.WriteLine("\nMovies (Forward):");
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }
    public void DisplayReverse()
    {
        Movie temp = tail;
        Console.WriteLine("\nMovies(Reverse):");
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }

    private void DisplayMovie(Movie m)
    {
        Console.WriteLine($"Title: {m.Title}, Director: {m.Director}, Year: {m.Year}, Rating: {m.Rating}");
    }
}

class Program
{
    static void Main()
    {
        MovieList list = new MovieList();

        list.AddAtEnd("Inception", "Nolan", 2010, 8.8);
        list.AddAtBeginning("Interstellar", "Nolan", 2014, 8.6);
        list.AddAtEnd("Avatar", "Cameron", 2009, 7.8);
        list.AddAtPosition(2, "Titanic", "Cameron", 1997, 7.9);

        list.DisplayForward();
        list.DisplayReverse();

        Console.WriteLine("Search by Director: Nolan");
        list.Search(director: "Nolan");

        Console.WriteLine("Update Rating of Avatar");
        list.UpdateRating("Avatar", 8.2);

        list.RemoveByTitle("Titanic");

        list.DisplayForward();
    }
}
