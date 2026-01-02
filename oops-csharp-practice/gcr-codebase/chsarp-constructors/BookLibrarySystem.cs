using System;

class Book{
    public long ISBN;
    protected string title;
    private string author;

    public Book(long isbn, string title, string author){
        this.ISBN = isbn;
        this.title = title;
        this.author = author;
    }
	
    public void SetAuthor(string author){
        this.author = author;
    }

    public string GetAuthor(){
        return author;
    }
}

// Subclass
class EBook : Book{
    public EBook(long isbn, string title, string author)
        : base(isbn, title, author){
    }

    public void DisplayEBookDetails(){
        Console.WriteLine("ISBN : " + ISBN);     // public
        Console.WriteLine("Title : " + title);   // protected
        Console.WriteLine("Author : " + GetAuthor()); // private
    }
}

class BookLibrarySystem{
    static void Main(){
        EBook b1 = new EBook(123455643, "C#", "Animesh");

        b1.DisplayEBookDetails();

        b1.SetAuthor("Rajpoot");
        Console.WriteLine("Updating Author");
        b1.DisplayEBookDetails();
    }
}
