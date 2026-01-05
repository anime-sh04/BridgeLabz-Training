using System;

class Person{
    public string Name;
    public int Age;

    public Person(string name,int age){
        Name = name;
        Age =age;
    }

    public void ShowPerson(){
        Console.WriteLine("Name: "+ Name);
        Console.WriteLine("Age: " +Age);
    }
}

class Teacher :Person{
    public string Subject;

    public Teacher(string name,int age,string subject)
        : base(name,age){
        Subject =subject;
    }

    public void DisplayRole(){
        Console.WriteLine("Role: Teacher");
        ShowPerson();
        Console.WriteLine("Subject: " +Subject);
    }
}

class Student :Person{
    public string Grade;

    public Student(string name,int age,string grade)
        :base(name,age){
        Grade =grade;
    }

    public void DisplayRole(){
        Console.WriteLine("Role: Student");
        ShowPerson();
        Console.WriteLine("Grade: "+ Grade);
    }
}

class Staff :Person{
    public string Department;

    public Staff(string name,int age,string department)
        :base(name,age){
        Department= department;
    }

    public void DisplayRole(){
        Console.WriteLine("Role: Staff");
        ShowPerson();
        Console.WriteLine("Department: "+ Department);
    }
}

class SchoolSystem{
    static void Main(string[] args){
        Teacher t = new Teacher("Animesh",35,"Math");
        Student s = new Student("ANimeshad",18,"12th");
        Staff st = new Staff("Anruwfh",40,"Admini");

        t.DisplayRole();
        Console.WriteLine();

        s.DisplayRole();
        Console.WriteLine();

        st.DisplayRole();
    }
}
