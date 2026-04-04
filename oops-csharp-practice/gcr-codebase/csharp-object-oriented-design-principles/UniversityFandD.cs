using System;
using System.Collections.Generic;

class Faculty{
    public string Name;
    public Faculty(string name){
        Name =name;
    }
}

class Department{
    public string DeptName;
    public Department(string name){
        DeptName = name;
    }
}

class University{
    public string UniName;
    private List<Department> departments = new List<Department>();
    public List<Faculty> facultyMembers = new List<Faculty>();

    public University(string name){
        UniName = name;
    }

    public void AddDepartment(Department d){
        departments.Add(d);
    }

    public void AddFaculty(Faculty f){
        facultyMembers.Add(f);
    }

    public void ShowDetails(){
        Console.WriteLine("University : " + UniName);
        Console.WriteLine("Departments :");
        foreach(Department d in departments){
            Console.WriteLine(d.DeptName);
        }
        Console.WriteLine("Faculty :");
        foreach(Faculty f in facultyMembers){
            Console.WriteLine(f.Name);
        }
    }
}

class UniversityFandD{
    static void Main(string[] args){
        Faculty f1 = new Faculty("Dr.Sharma");
        Faculty f2 = new Faculty("Dr.Mehta");

        University u = new University("GLA");

        u.AddDepartment(new Department("C#"));
        u.AddDepartment(new Department("Java"));

        u.AddFaculty(f1);
        u.AddFaculty(f2);

        u.ShowDetails();

        Console.WriteLine("Deleting University");
        u = null;

        Console.WriteLine("Faculty still exists :" +f1.Name);
    }
}
