using System;
using System.Collections.Generic;

namespace CourseManagement
{
    // Abstract base class
    public abstract class CourseBase
    {
        public string Name { get; private set; }

        protected CourseBase(string name)
        {
            Name = name;
        }

        public abstract void Assess(string student);
    }

    // Exam-based course
    public class WrittenExamCourse : CourseBase
    {
        public WrittenExamCourse(string name) : base(name) { }

        public override void Assess(string student)
        {
            Console.WriteLine($"{student} assessed through written exam in {Name}");
        }
    }

    public class CourseworkCourse : CourseBase
    {
        public CourseworkCourse(string name) : base(name) { }

        public override void Assess(string student)
        {
            Console.WriteLine($"{student} assessed through assignments in {Name}");
        }
    }

    public class CourseManager<T> where T : CourseBase
    {
        private readonly List<T> courseList = new List<T>();

        public void RegisterCourse(T course)
        {
            courseList.Add(course);
        }

        public void AssessStudent(string student)
        {
            foreach (T c in courseList)
            {
                c.Assess(student);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string studentA = "John Doe";
            string studentB = "Jane Smith";

            var examManager = new CourseManager<WrittenExamCourse>();
            examManager.RegisterCourse(new WrittenExamCourse("Mathematics"));
            examManager.RegisterCourse(new WrittenExamCourse("Physics"));

            var assignmentManager = new CourseManager<CourseworkCourse>();
            assignmentManager.RegisterCourse(new CourseworkCourse("Literature"));
            assignmentManager.RegisterCourse(new CourseworkCourse("History"));

            Console.WriteLine("Exam Course Evaluation:");
            examManager.AssessStudent(studentA);

            Console.WriteLine("\nAssignment Course Evaluation:");
            assignmentManager.AssessStudent(studentB);
        }
    }
}
