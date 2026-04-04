using System;

class Person{
    private string name;
    private int age;

    // Parameterized Constructor
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    // Copy Constructor
    public Person(Person other){
        this.name = other.name;
        this.age = other.age;
    }

    public void Display(){
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }
}

class PersonClass{
    static void Main(){
        Person p1 = new Person("Animesh", 20);
        Person p2 = new Person(p1);

        p1.Display();
        p2.Display();
    }
}
