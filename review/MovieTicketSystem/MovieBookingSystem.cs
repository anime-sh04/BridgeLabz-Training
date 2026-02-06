using System;

class MovieBookingSystem{
	static string[] movies = new string[10];
	static double[] prices = new double[10];
	static int[] tickets = new int[10];
	
	static void Main(string[] args){
		MovieBookingSystem m = new MovieBookingSystem();
		m.Menu();
	}
	
	public void BookTicket(){
		Console.WriteLine("Enter Movie Index to book");
		int movieToBook = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Number Of tickets to book");
		int numberOfTicketToBook = int.Parse(Console.ReadLine());
		
		if(tickets[movieToBook] < numberOfTicketToBook){
			Console.WriteLine("Not enough ticket sorry!");
		}
		else{
			Console.WriteLine("Booked!\n    Your Total Bill : "+(prices[movieToBook-1]*tickets[movieToBook-1]));
			tickets[movieToBook-1] = tickets[movieToBook-1]-numberOfTicketToBook;
		}
	}

	
	public void DisplayMovieList(){
		if(movies[0] ==null){
			Console.WriteLine("No movies Listed Yet!");
			return;
		}
		for(int i=0;i<10;i++){
			if(movies[i] ==null)
				break;
			else
				Console.WriteLine((i+1)+". " + movies[i] +"  /  Price : " +prices[i]+"  /  Ticket Left : " +tickets[i]);
			
		}
	}
	
	public void AddMovies(){
		Console.WriteLine("Enter The number Of movies to Add");
		int numberOfMoviesToAdd = int.Parse(Console.ReadLine());
		for(int i=0;i<numberOfMoviesToAdd;i++){
			Console.WriteLine("Enter "+(i+1)+ " movie name");
			movies[i] = Console.ReadLine();
			Console.WriteLine("Enter "+(i+1)+ " movie ticket price");
			prices[i] = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter "+(i+1)+ " movie ticket Quantity");
			tickets[i] = int.Parse(Console.ReadLine());
		}
	}
			
	
	public void Menu(){
		
		while(true){
			Console.WriteLine("1. Admin Login");
			Console.WriteLine("2. User Login");
			Console.WriteLine("3. Exit");
			
			int choice = int.Parse(Console.ReadLine());
			switch(choice){
				case 1:
					Console.WriteLine("Enter Password");
					string password = "12345";
					string pass = Console.ReadLine();
					if(pass == password){
						Console.WriteLine("----------------------------");
						Console.WriteLine("			Welcome!");
						Console.WriteLine("1. To Add Movies");
						Console.WriteLine("2. Exit");
						
						int choice2 = int.Parse(Console.ReadLine());
						if(choice2 == 2)
							break;
						switch(choice2){
							case 1:
								AddMovies();
								break;
							default:
								Console.WriteLine("Invalid Choice");
								break;
						}
					}
					else{
						Console.WriteLine("Wrong Password");
						break;
					}
					break;
				case 2:
					Console.WriteLine("----------------------------");
					Console.WriteLine("			Welcome!");
					Console.WriteLine("1. Display Movie List");
					Console.WriteLine("2. Book Ticket");
					Console.WriteLine("3. Exit");
					int choice3 = int.Parse(Console.ReadLine());
					if(choice3==3)
						break;
					switch(choice3){
						case 1:
							DisplayMovieList();
							break;
						case 2:
							BookTicket();
							break;
						
						default:
							Console.WriteLine("Invalid Choice");
							break;
						}
					
					break;
				case 3:
					return;
				
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
}
