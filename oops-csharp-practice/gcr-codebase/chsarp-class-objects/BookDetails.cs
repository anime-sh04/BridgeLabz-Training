using System;

class BookDetails{
	private string title;
	private string author;
	private double price;
	
	public BookDetails(string title, string author,double price){
		this.title = title;
		this.author = author;
		this.price = price;
	}
	public void DisplayDetails(){
		Console.WriteLine("Book Title : " + title);
		Console.WriteLine("Book Author : " + author);
		Console.WriteLine("Book Price: " + price);
	}
}

class Book{
	static void Main(string[] args){
		BookDetails book = new BookDetails("C# Programming","Animesh",125.5);
		
		book.DisplayDetails();
	}
}