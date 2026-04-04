using System;
using System.Collections.Generic;
class Course{
    public string CourseName;
    private List<Student> students = new List<Student>();

    public Course(string name){
        CourseName =name;
    }

    public void AddStudent(Student s){
        if(!students.Contains(s)){
            students.Add(s);
        }
    }

    public void ShowStudents(){
        Console.WriteLine("Course:"+ CourseName);
        foreach(Student s in students){
            Console.WriteLine(" " +s.Name);
        }
    }
}
class Student{
    public string Name;
    private List<Course> courses = new List<Course>();

    public Student(string name){
        Name = name;
    }

    public void EnrollCourse(Course c){
        if(!courses.Contains(c)){
            courses.Add(c);
            c.AddStudent(this);
        }
    }

    public void ShowCourses(){
        Console.WriteLine("Student: " +Name);
        foreach(Course c in courses){
            Console.WriteLine(c.CourseName);
        }
    }
}
class School{
    public string SchoolName;
    private List<Student> students = new List<Student>();

    public School(string name){
        SchoolName =name;
    }

    public void AddStudent(Student s){
        students.Add(s);
    }

    public void ShowStudents(){
        Console.WriteLine("School: " + SchoolName);
        foreach(Student s in students){
            Console.WriteLine(s.Name);
        }
    }
}
class SchoolAndStudents{
    static void Main(){
        School school = new School("GLA");
        Student s1 = new Student("Animesh");
        Student s2 = new Student("Ravi");

        Course c1 = new Course("Math");
        Course c2 = new Course("Science");
        Course c3 = new Course("Computer");

        school.AddStudent(s1);
        school.AddStudent(s2);

        s1.EnrollCourse(c1);
        s1.EnrollCourse(c3);

        s2.EnrollCourse(c1);
        s2.EnrollCourse(c2);

        school.ShowStudents();

        s1.ShowCourses();
        s2.ShowCourses();

        c1.ShowStudents();
        c2.ShowStudents();
        c3.ShowStudents();
    }
}
