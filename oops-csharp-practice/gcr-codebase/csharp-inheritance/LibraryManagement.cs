using System;

class Book{

    protected string Title;
    protected int PublicationYear;

    public Book(string title,int year){
        Title = title;
        PublicationYear = year;
    }

    public virtual void DisplayInfo(){
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Publication Year : " + PublicationYear);
    }
}

class Author : Book{

    string Name;
    string Bio;

    public Author(string title,int year,string name,string bio) : base(title,year){
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Author Name : " + Name);
        Console.WriteLine("Author Bio : " + Bio);
    }
}

class LibraryManagement{
    static void Main(string[] args){
        Author a = new Author("Animesh",1988,"Ahgwafg","Smapele");

        a.DisplayInfo();
    }
}
