using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public string DueDate;

    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string date)
    {
        TaskID = id;
        TaskName = name;
        Priority = priority;
        DueDate = date;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head;
    private TaskNode current;

    // Add at beginning
    public void AddAtBeginning(int id, string name, int priority, string date)
    {
        TaskNode newNode = new TaskNode(id, name, priority, date);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }
    }

    // Add at end
    public void AddAtEnd(int id, string name, int priority, string date)
    {
        TaskNode newNode = new TaskNode(id, name, priority, date);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    // Add at position
    public void AddAtPosition(int pos, int id, string name, int priority, string date)
    {
        if (pos <= 1)
        {
            AddAtBeginning(id, name, priority, date);
            return;
        }

        TaskNode temp = head;
        for (int i = 1; i < pos - 1 && temp.Next != head; i++)
            temp = temp.Next;

        TaskNode newNode = new TaskNode(id, name, priority, date);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void RemoveByID(int id)
    {
        if (head == null) return;

        TaskNode curr = head;
        TaskNode prev = null;

        do
        {
            if (curr.TaskID == id)
            {
                if (curr == head)
                {
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                    prev.Next = curr.Next;

                Console.WriteLine("Task removed successfully.");
                return;
            }
            prev = curr;
            curr = curr.Next;
        } while (curr != head);

        Console.WriteLine("Task not found.");
    }

    // View current and move next
    public void ViewNextTask()
    {
        if (current == null) return;

        Console.WriteLine("\nCurrent Task:");
        DisplayTask(current);
        current = current.Next;
    }

    // Display all tasks
    public void DisplayAll()
    {
        if (head == null) return;

        TaskNode temp = head;
        Console.WriteLine("\nAll Tasks:");

        do
        {
            DisplayTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search by priority
    public void SearchByPriority(int priority)
    {
        if (head == null) return;

        TaskNode temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                DisplayTask(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No task found with given priority.");
    }

    private void DisplayTask(TaskNode t)
    {
        Console.WriteLine($"ID: {t.TaskID}, Name: {t.TaskName}, Priority: {t.Priority}, Due: {t.DueDate}");
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddAtEnd(1, "Coding", 1, "10-Jan");
        scheduler.AddAtEnd(2, "Study", 2, "12-Jan");
        scheduler.AddAtBeginning(3, "Workout", 1, "9-Jan");
        scheduler.AddAtPosition(2, 4, "Project", 3, "15-Jan");

        scheduler.DisplayAll();

        scheduler.ViewNextTask();
        scheduler.ViewNextTask();

        Console.WriteLine("\nSearch Priority 1:");
        scheduler.SearchByPriority(1);

        scheduler.RemoveByID(2);

        scheduler.DisplayAll();
    }
}
