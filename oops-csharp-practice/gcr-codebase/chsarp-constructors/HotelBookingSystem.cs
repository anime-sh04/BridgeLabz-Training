using System;

class Hotel{
    private string GuestName;
    private string RoomType;
	private int Nights;
	
	//Default
	public Hotel(){
		GuestName = "Animesh Rajpoot";
		RoomType = "Double";
		Nights = 4;
	}
    //Parameterized Constructor
    public Hotel(string guestname, string roomtype , int nights){
        this.GuestName = guestname;
		this.RoomType = roomtype;
        this.Nights = nights;
    }

    //Copy Constructor
    public Hotel(Hotel other){
        this.GuestName = other.GuestName;
		this.RoomType = other.RoomType;
        this.Nights = other.Nights;
    }

    public void Display(){
        Console.WriteLine("Name : " + GuestName);
        Console.WriteLine("RoomType  : " + RoomType);
        Console.WriteLine("Nights  : " + Nights);
    }
}

class HotelBookingSystem{
    static void Main(){
		Hotel h1 = new Hotel();
        Hotel h2 = new Hotel("Animesh", "Single",7);
        Hotel h3 = new Hotel(h2);

		h1.Display();
		h2.Display();
		h3.Display();
    }
}
