using System;

class Book{
    private string Title;
    private string Author;
	private double Price;
	private bool Availabilty;
	
    //Parameterized Constructor
    public Book(string Title, string Author , double Price,bool availabilty){
        this.Title = Title;
		this.Author = Author;
        this.Price = Price;
		this.Availabilty = availabilty;
    }

	public void BorrowBook(){
		Console.WriteLine("You borrowed the book");
		Availabilty = false;
	}
	
    public void Display(){
        Console.WriteLine("Name : " + Title);
        Console.WriteLine("Author  : " + Author);
        Console.WriteLine("Price  : " + Price);
        Console.WriteLine("Availabilty : " + Availabilty);
    }
}

class LibraryBookSystem{
    static void Main(){
        
		Book b = new Book("C# Practice","Animesh",123.35,true);

		b.Display();
		b.BorrowBook();
		b.Display();
    }
}
