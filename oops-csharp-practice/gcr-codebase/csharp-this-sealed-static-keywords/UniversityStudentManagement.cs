using System;

class Student{
    static string UniversityName = "GLA";

    private string Name;
    private readonly int RollNumber;
    private string Grade;
    private static int TotalStudents =0;

    public Student(int rollnumber, string name, string grade){
        this.RollNumber =rollnumber;
        this.Name =name;
        this.Grade = grade;
        TotalStudents++;
    }

    public void DisplayStudentDetails(){
        Console.WriteLine("University Name : " + UniversityName);
        Console.WriteLine("Roll Number : " + RollNumber);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Grade : " + Grade);
    }

    public void UpdateGrade(string newGrade){
        Grade =newGrade;
    }

    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students in " + UniversityName+" are : "+ TotalStudents);
    }
}

class UniversityStudentManagement{
    static void Main(string[] args){
        Student s1 = new Student(101,"Animesh", "A");
        Student s2 = new Student(102,"KNhu","B");
        if(s1 is Student)
            Console.WriteLine("Yes its from Student class");
        else
            Console.WriteLine("No its not from Student class");

        s1.DisplayStudentDetails();
        s2.DisplayStudentDetails();

        s2.UpdateGrade("A");
        Console.WriteLine("After Grade Update:");
        s2.DisplayStudentDetails();

        Student.DisplayTotalStudents();
    }
}
