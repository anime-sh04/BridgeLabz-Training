using System;

class Book{
    static string LibraryName = "Central Library";
    private readonly string ISBN;
    private string Title;
    private string Author;

    private static int TotalBooks = 0;

    public Book(string title, string author, string isbn){
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
        TotalBooks++;
    }

    public void DisplayBookDetails(){
        Console.WriteLine("Library Name : " + LibraryName);
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Author : " + Author);
        Console.WriteLine("ISBN : " + ISBN);
    }

    public static void DisplayTotalBooks(){
        Console.WriteLine("Total Books in "+LibraryName +" are : "+ TotalBooks);
    }
}

class LibraryManagementSystem{
    static void Main(string[] args){
        Book b1 = new Book("C#", "Animwah", "35636");
        Book b2 = new Book("Java", "Ajnqr", "2341234");

        if(b1 is Book)
            Console.WriteLine("Yes its from Book class");
        else
            Console.WriteLine("No its not from Book class");

        b1.DisplayBookDetails();
        b2.DisplayBookDetails();
        Book.DisplayTotalBooks();
    }
}
