using System;

namespace ParcelTracker
{
    class TrackerMenu
    {
        ITracker tracker = new TrackerUtilityImpl();

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Parcel Tracker Menu ---");
                Console.WriteLine("1. Mark Packed");
                Console.WriteLine("2. Mark Shipped");
                Console.WriteLine("3. Mark In Transit");
                Console.WriteLine("4. Mark Delivered");
                Console.WriteLine("5. Add Custom Checkpoint");
                Console.WriteLine("6. Display Tracking");
                Console.WriteLine("7. Mark Parcel as Lost");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        tracker.AddStage("Packed");
                        break;
                    case 2:
                        tracker.AddStage("Shipped");
                        break;
                    case 3:
                        tracker.AddStage("In Transit");
                        break;
                    case 4:
                        tracker.AddStage("Delivered");
                        break;
                    case 5:
                        Console.Write("Enter stage AFTER which to add checkpoint: ");
                        string after = Console.ReadLine();

                        Console.Write("Enter checkpoint name: ");
                        string cp = Console.ReadLine();

                        tracker.AddCheckpoint(after, cp);
                        break;
                    case 6:
                        tracker.Display();
                        break;
                    case 7:
                        tracker.MarkLost();
                        break;
                    case 8:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 8);
        }
    }
}
