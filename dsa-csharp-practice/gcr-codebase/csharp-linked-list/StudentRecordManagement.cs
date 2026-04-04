//using System;

//namespace LinkedList
//{
//    class Student
//    {
//        public long RollNumber;
//        public string Name;
//        public int Age;
//        public string Grade;
//        public Student Next;

//        public Student(long rollNumber, string name, int age, string grade)
//        {
//            RollNumber = rollNumber;
//            Name = name;
//            Age = age;
//            Grade = grade;
//            Next = null;
//        }
//    }

//    class StudentLinkedList
//    {
//        private Student head;
//        public void AddAtBeginning(long roll, string name, int age, string grade)
//        {
//            Student newNode = new Student(roll, name, age, grade);
//            newNode.Next = head;
//            head = newNode;
//        }

//        public void AddAtEnd(long roll, string name, int age, string grade)
//        {
//            Student newNode = new Student(roll, name, age, grade);

//            if (head == null)
//            {
//                head = newNode;
//                return;
//            }

//            Student temp = head;
//            while (temp.Next != null)
//                temp = temp.Next;

//            temp.Next = newNode;
//        }

//        public void AddAtPosition(long roll, string name, int age, string grade, int position)
//        {
//            if (position==0)
//            {
//                AddAtBeginning(roll, name, age, grade);
//                return;
//            }

//            Student newNode = new Student(roll, name, age, grade);
//            Student temp = head;

//            for (int i = 0; i < position - 1 && temp != null; i++)
//                temp = temp.Next;

//            if (temp == null)
//            {
//                Console.WriteLine("Position out of range.");
//                return;
//            }

//            newNode.Next = temp.Next;
//            temp.Next = newNode;
//        }

//        public void Delete(long roll)
//        {
//            if (head == null) return;

//            if (head.RollNumber == roll)
//            {
//                head = head.Next;
//                return;
//            }

//            Student temp = head;
//            while (temp.Next != null && temp.Next.RollNumber != roll)
//                temp = temp.Next;

//            if (temp.Next == null)
//                Console.WriteLine("Student not found.");
//            else
//                temp.Next = temp.Next.Next;
//        }
//        public void Search(long roll)
//        {
//            Student temp = head;

//            while (temp != null)
//            {
//                if (temp.RollNumber == roll)
//                {
//                    Console.WriteLine($"Found: {temp.Name}, Age {temp.Age}, Grade {temp.Grade}");
//                    return;
//                }
//                temp = temp.Next;
//            }

//            Console.WriteLine("Student not found.");
//        }
//        public void UpdateGrade(long roll, string newGrade)
//        {
//            Student temp = head;

//            while (temp != null)
//            {
//                if (temp.RollNumber == roll)
//                {
//                    temp.Grade = newGrade;
//                    Console.WriteLine("Grade updated.");
//                    return;
//                }
//                temp = temp.Next;
//            }

//            Console.WriteLine("Student not found.");
//        }

//        public void Display()
//        {
//            Student temp = head;

//            while (temp != null)
//            {
//                Console.WriteLine($"{temp.RollNumber} | {temp.Name} | {temp.Age} | {temp.Grade}");
//                temp = temp.Next;
//            }
//        }
//    }

//    class StudentRecordManagement
//    {
//        static void Main()
//        {
//            StudentLinkedList list = new StudentLinkedList();

//            list.AddAtBeginning(101, "Animesh", 21, "A");
//            list.AddAtEnd(102, "Anubhav", 20, "B");
//            list.AddAtPosition(103, "Rahul", 22, "C", 1);

//            list.Display();

//            list.Search(102);
//            list.UpdateGrade(102, "A+");
//            list.Delete(101);

//            Console.WriteLine("\nAfter Updates:");
//            list.Display();
//        }
//    }
//}
