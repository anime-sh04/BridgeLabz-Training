using System;

class Person{
    public string Name;
    public int Id;

    public Person(string name,int id){
        Name =name;
        Id = id;
    }

    public void ShowPerson(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
    }
}

interface IWorker{
    void PerformDuties();
}

class Chef : Person, IWorker{
    public Chef(string name,int id): base(name,id){}

    public void PerformDuties(){
        Console.WriteLine("Role: Chef");
        Console.WriteLine("Duties: Cooking food and managing kitchen");
    }
}

class Waiter : Person, IWorker{
    public Waiter(string name,int id) :base(name,id){}

    public void PerformDuties(){
        Console.WriteLine("Role: Waiter");
        Console.WriteLine("Duties: Serving food and assisting customers");
    }
}

class RestaurantManagementSystem{
    static void Main(string[] args){
        Chef c = new Chef("Animesh",101);
        Waiter w = new Waiter("Ravi",102);

        c.ShowPerson();
        c.PerformDuties();

        Console.WriteLine();

        w.ShowPerson();
        w.PerformDuties();
    }
}
