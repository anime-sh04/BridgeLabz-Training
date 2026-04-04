using System;

namespace ParcelTracker
{
    class TrackerUtilityImpl : ITracker
    {
        private ParcelNode head = null;
        public void AddStage(string stage)
        {
            ParcelNode newNode = new ParcelNode(stage);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ParcelNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }

            Console.WriteLine(stage + " stage marked successfully!");
        }
        public void AddCheckpoint(string afterStage, string checkpoint)
        {
            if (head == null)
            {
                Console.WriteLine("Parcel not started!");
                return;
            }

            ParcelNode temp = head;

            while (temp != null && temp.Stage != afterStage)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Stage not found!");
                return;
            }

            ParcelNode newNode = new ParcelNode(checkpoint);
            newNode.Next = temp.Next;
            temp.Next = newNode;

            Console.WriteLine("Checkpoint added successfully!");
        }

        // Display tracking
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No stages passed yet!");
                return;
            }

            ParcelNode current = head;
            while (current != null)
            {
                Console.Write(current.Stage + " -> ");
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }
        public void MarkLost()
        {
            if (head == null)
            {
                Console.WriteLine("Parcel not started!");
                return;
            }

            ParcelNode temp = head;

            while (temp.Next != null && temp.Next.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = null;
            Console.WriteLine("Parcel marked as LOST!");
        }
    }
}
