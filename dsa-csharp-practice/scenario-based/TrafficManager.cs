using System;

namespace TrafficManager
{
    class Vehicle
    {
        public int Id;
        public Vehicle Next;
        public Vehicle(int id)
        {
            Id = id;
            Next = null;
        }
    }
    class VehicleQueue
    {
        private Vehicle front;
        private Vehicle rear;
        public VehicleQueue()
        {
            front = null;
            rear = null;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Enqueue(Vehicle v)
        {
            if (rear ==null)
            {
                front = rear=v;
            }
            else
            {
                rear.Next = v;
                rear = v;
            }
        }

        public Vehicle Dequeue()
        {
            if (IsEmpty())
                return null;

            Vehicle temp = front;
            front = front.Next;

            if (front ==null)
                rear = null;

            temp.Next = null;
            return temp;
        }
    }

    class TrafficManager
    {
        private Vehicle head;
        private int count;
        private int capacity;
        private VehicleQueue waitingQueue;

        public TrafficManager()
        {
            head = null;
            count = 0;
            capacity = 3;
            waitingQueue = new VehicleQueue();
        }

        public void AddCar(int id)
        {
            Vehicle newVehicle = new Vehicle(id);

            if (count == capacity)
            {
                Console.WriteLine("Roundabout full-Vehicle added to waiting queue");
                waitingQueue.Enqueue(newVehicle);
                return;
            }

            if (head == null)
            {
                head = newVehicle;
                head.Next = head;
            }
            else
            {
                Vehicle temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newVehicle;
                newVehicle.Next = head;
            }

            count++;
            Console.WriteLine($"Vehicle {id} entered roundabout");
        }

        public void RemoveCar(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }

            Vehicle curr = head;
            Vehicle prev = null;

            do
            {
                if (curr.Id == id)
                {
                    if (curr == head)
                    {
                        Vehicle last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                    }

                    count--;
                    Console.WriteLine($"Vehicle {id} exited roundabout");

                    if (!waitingQueue.IsEmpty())
                    {
                        Vehicle v = waitingQueue.Dequeue();
                        AddCar(v.Id);
                    }
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != head);

            Console.WriteLine("Vehicle not found");
        }

        public void DisplayTraffic()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }

            Vehicle temp = head;
            Console.Write("Roundabout: ");
            do
            {
                Console.Write(temp.Id + " - ");
                temp = temp.Next;
            } while (temp != head);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficManager v = new TrafficManager();

            while (true)
            {
                Console.WriteLine("\n1. Add Car\n2. Remove Car\n3. Display\n0. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Vehicle ID: ");
                        int id = int.Parse(Console.ReadLine());
                        v.AddCar(id);
                        break;

                    case 2:
                        Console.Write("Enter Vehicle ID to remove: ");
                        int id2= int.Parse(Console.ReadLine());
                        v.RemoveCar(id2);
                        break;

                    case 3:
                        v.DisplayTraffic();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
