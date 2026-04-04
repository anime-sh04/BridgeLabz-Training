using System;
using System.Collections.Generic;
class Book{
    public string Title;
    public string Author;

    public Book(string title,string author){
        Title = title;
        Author = author;
    }

    public void Display(){
        Console.WriteLine(Title + "/" + Author);
    }
}

class Library{
    public string Name;
    private List<Book> books = new List<Book>();

    public Library(string name){
        Name =name;
    }

    public void AddBook(Book b){
        books.Add(b);
    }

    public void ShowBooks(){
        Console.WriteLine("Library: " + Name);
        foreach(Book b in books){
            b.Display();
        }
    }
}

class LibraryAndBooks{
    static void Main(string[] args){
        Book b1 = new Book("C#","Animesh");
        Book b2 = new Book("Java","Animesh2");
        Book b3 = new Book("Python","Animesh3");

        Library l1 = new Library("Library");
        Library l2 = new Library("Library2");
        l1.AddBook(b1);
        l1.AddBook(b2);
		
        l2.AddBook(b2);
        l2.AddBook(b3);
		
        l1.ShowBooks();
        l2.ShowBooks();
    }
}
