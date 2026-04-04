using System;

class Book{
	private string Title;
	private string Author;
	private double Price;
	
	// Default Constructor 
	public Book(){
		Title = "C# practice";
		Author = "Animesh Rajpoot";
		Price = 290.00;
	}
	// Parameterized Constructor 
	public Book(string title, string author , double price){
		Title = title;
		Author = author;
		Price = price;
	}
	public void Display(){
		Console.WriteLine("Title : " + Title);
		Console.WriteLine("Author : " + Author);
		Console.WriteLine("Price : " + Price);
	}
}

class BookClass{
	static void Main(string[] args){
		Book b = new Book();
		Book b1 = new Book("Java","Animesh",123.35);
		b.Display();
		b1.Display();
	}
}