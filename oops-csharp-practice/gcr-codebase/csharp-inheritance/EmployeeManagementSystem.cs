using System;

class Employee{
    protected string Name;
    protected int Id;
    protected double Salary;

    public Employee(string name,int id,double salary){
        Name=name;
        Id=id;
        Salary=salary;
    }

    public virtual void DisplayDetails(){
        Console.WriteLine("Name : "+ Name);
        Console.WriteLine("ID : "+ Id);
        Console.WriteLine("Salary : "+ Salary);
    }
}

class Manager:Employee{
    int TeamSize;

    public Manager(string name,int id,double salary,int teamsize):base(name,id,salary){
        TeamSize=teamsize;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Team Size : "+TeamSize);
    }
}

class Developer:Employee{
    string ProgrammingLanguage;

    public Developer(string name,int id,double salary,string language):base(name,id,salary){
        ProgrammingLanguage=language;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Programming Language : "+ProgrammingLanguage);
    }
}

class Intern:Employee{
    string InternshipDuration;

    public Intern(string name,int id,double salary,string duration):base(name,id,salary){
        InternshipDuration=duration;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Internship Duration : "+InternshipDuration);
    }
}

class EmployeeManagementSystem{
    static void Main(string[] args){
        Manager m= new Manager("Amit",101,90000 ,8);
        Developer d = new Developer("Riya", 102,70000, "C#");
        Intern i = new Intern("Animesh",103, 15000,"6 Months");

        Console.WriteLine("Manager Details");
        m.DisplayDetails();

        Console.WriteLine("Developer Details");
        d.DisplayDetails();

        Console.WriteLine("Intern Details");
        i.DisplayDetails();
    }
}
