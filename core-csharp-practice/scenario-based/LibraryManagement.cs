/*
. Library Management System – Book Search and Checkout
Scenario: You’re designing a system for a small library to manage books and track checkouts.
Problem Requirements:
● Store book details (title, author, status) in a Array.
● Allow searching by partial title using String operations.
● Store book data in an Array.
● Use methods for searching, displaying, and updating book status (checked out or
available).*/
using System;

class LibraryManagement{
	static void Main(string[] args){
		LibraryManagement ob = new LibraryManagement();
		ob.Input();
	}
	void Input(){
		Console.WriteLine("Enter Number of Books : ");
		/* int numberOfBooks = int.Parse(Console.ReadLine()); */
		
		/*string[,] bookDetails = new string[3,n];
			
		for(int i=0;i<n;i++){
			for(int j=0;j<3;j++){
				if(j==0){
					Console.WriteLine("Enter Book name : ");
					bookDetails[j,i]= Console.ReadLine();
				}
				else if(j==1){
					Console.WriteLine("Enter author name : ");
					bookDetails[j,i]= Console.ReadLine();
				}
				else{
					Console.WriteLine("Enter Book status : ");
					bookDetails[j,i]= Console.ReadLine();
				}
			}
		}
		 */
		 
		string[,] bookDetails =
		{
			{ "The Pragmatic Programmer", "Andrew Hunt", "Available" },
			{ "Introduction to Algorithms", "Thomas H. Cormen", "Checked Out" },
			{ "Design Patterns", "Erich Gamma", "Available" },
			{ "Operating System Concepts", "Abraham Silberschatz", "Available" },
			{ "Computer Networks", "Andrew S. Tanenbaum", "Checked Out" },
			{ "Artificial Intelligence", "Stuart Russell", "Available" }
		};

			
		int numberOfBooks = bookDetails.GetLength(0);
			
		
		while(true){
			Console.WriteLine("1. Search Book");
			Console.WriteLine("2. Display Books");
			Console.WriteLine("3. Change Book Status");
			Console.WriteLine("4. Exit");
			Console.WriteLine("\n\n");
			int n = int.Parse(Console.ReadLine());
			
			switch(n){
			case 1:
				Console.WriteLine("Enter Book Name : ");
				string bookName = Console.ReadLine();
				int bookPlace = SearchBook(bookName ,bookDetails, numberOfBooks);
				break;
			case 2:
				DisplayBooks(bookDetails);
				break;
			case 3:
				UpdateBookStatus(bookDetails, numberOfBooks);
				break;
			case 4:
				return;
			default:
				Console.WriteLine("Invalid Choice");
				break;
			}
		}
	}
	
	int SearchBook(string bookName,string[,] bookDetails, int numberOfBooks){
		int change = -1;
		for(int i=0;i<numberOfBooks;i++){
			for(int j=0;j<bookDetails.GetLength(1);j++){
				if(bookDetails[i,j].ToLower().Contains(bookName.ToLower())){
					Console.WriteLine("Book Found \n");
					Console.WriteLine("Title : "+bookDetails[i,0] + " / Author Name : "+bookDetails[i,1]+ " / Currently : "+bookDetails[i,2]);
					Console.WriteLine("\n\n");
					change = i;
					return change;
				}
			}
		}
		if(change==-1){
			Console.WriteLine("Not Found");
		}
		return -1; 
	}
	
	void DisplayBooks(string[,] bookDetails){
		int bookCounter = 1;
		for(int i=0;i<bookDetails.GetLength(0);i++){
			Console.WriteLine("Title : "+bookDetails[i,0] + " / Author Name : "+bookDetails[i,1]+ " / Currently : "+bookDetails[i,2]);
			bookCounter++;
		}
		Console.WriteLine("\n\n");
	}
	void UpdateBookStatus(string[,] bookDetails, int numberOfBooks){
		Console.WriteLine("Enter Book Name whose status you want to update: ");
		string bookNameStatus = Console.ReadLine();
		int toChange = SearchBook(bookNameStatus, bookDetails,numberOfBooks);
		
		Console.WriteLine("1. Change status");
		Console.WriteLine("2. Exit");
		Console.WriteLine("\n\n");
		int changeStatusTo = int.Parse(Console.ReadLine());
			
		switch(changeStatusTo){
			case 1:
				if(bookDetails[toChange,2] == "Available"){
					bookDetails[toChange,2] = "Checked Out";
					Console.WriteLine("Book status changed to Checked Out");
				}
				else{
					bookDetails[toChange,2] = "Available";
					Console.WriteLine("Book status changed to Available");
				}
				break;
			case 2:
				return;
		}
		
	}
}