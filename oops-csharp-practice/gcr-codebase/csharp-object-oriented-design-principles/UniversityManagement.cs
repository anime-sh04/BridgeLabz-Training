using System;
using System.Collections.Generic;

class Student{
    public string Name;
    private List<Course> courses = new List<Course>();

    public Student(string name){
        Name = name;
    }

    public void EnrollCourse(Course c){
        courses.Add(c);
        Console.WriteLine(Name + " enrolled in" +c.CourseName);
    }
}

class Professor{
    public string Name;

    public Professor(string name){
        Name = name;
    }

    public void AssignProfessor(Course c){
        c.SetProfessor(this);
        Console.WriteLine(Name + " is assigned t" +c.CourseName);
    }
}

class Course{
    public string CourseName;
    private Professor professor;

    public Course(string name){
        CourseName = name;
    }

    public void SetProfessor(Professor p){
        professor = p;
    }
}

class University{
    public string Name;
    public List<Student> students = new List<Student>();
    public List<Professor> professors = new List<Professor>();
    public List<Course> courses = new List<Course>();

    public University(string name){
        Name =name;
    }
}

class UniversityManagement{
    static void Main(string[] args){
        University u = new University("GLA");

        Student s1 =new Student("Animesh");
        Professor p1 =new Professor("Sahil sie");
        Course c1 = new Course("C#");

        u.students.Add(s1);
        u.professors.Add(p1);
        u.courses.Add(c1);

        s1.EnrollCourse(c1);
        p1.AssignProfessor(c1);
    }
}
