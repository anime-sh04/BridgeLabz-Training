using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class ProcessNode
{
    public int PID;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public int WaitingTime;
    public int TurnAroundTime;

    public ProcessNode Next;

    public ProcessNode(int pid, int burst, int priority)
    {
        PID = pid;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head = null;
    private int timeQuantum;

    public RoundRobinScheduler(int tq)
    {
        timeQuantum = tq;
    }

    // Add process at end
    public void AddProcess(int pid, int burst, int priority)
    {
        ProcessNode newNode = new ProcessNode(pid, burst, priority);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    // Remove finished process
    private void RemoveProcess(int pid)
    {
        ProcessNode curr = head, prev = null;

        do
        {
            if (curr.PID == pid)
            {
                if (curr == head)
                {
                    ProcessNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    if (curr.Next == head)
                        head = null;
                    else
                    {
                        head = curr.Next;
                        last.Next = head;
                    }
                }
                else
                    prev.Next = curr.Next;

                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);
    }

    // Display current queue
    private void DisplayQueue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue empty");
            return;
        }

        ProcessNode temp = head;
        do
        {
            Console.Write($"P{temp.PID}({temp.RemainingTime}) -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("...");
    }

    // Simulation
    public void Simulate()
    {
        int time = 0;
        Dictionary<int, int> finishTime = new Dictionary<int, int>();

        Console.WriteLine("\n--- Round Robin Execution ---");

        while (head != null)
        {
            ProcessNode curr = head;

            int exec = Math.Min(timeQuantum, curr.RemainingTime);
            curr.RemainingTime -= exec;
            time += exec;

            Console.WriteLine($"P{curr.PID} runs for {exec} units");

            if (curr.RemainingTime == 0)
            {
                finishTime[curr.PID] = time;
                RemoveProcess(curr.PID);
            }
            else
                head = head.Next;

            DisplayQueue();
        }

        // Compute times
        Console.WriteLine("\n--- Statistics ---");

        double totalWT = 0, totalTAT = 0;

        foreach (var p in finishTime)
        {
            int pid = p.Key;
            int completion = p.Value;

            Console.WriteLine($"Process {pid} completed at {completion}");

            totalTAT += completion;
        }

        int n = finishTime.Count;
        Console.WriteLine($"\nAverage Turnaround Time = {totalTAT / n}");
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(3);

        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 2);

        scheduler.Simulate();
    }
}
