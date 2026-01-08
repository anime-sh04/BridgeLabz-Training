namespace Smart_Home_Automation_System
{
    internal class ApplianceMain
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = [new Ac("Office AC"),new Fan("Room Fan"),new Light("Table Light")];


            while (true)
            {
                Console.WriteLine("\nSelect Appliance:");
                Console.WriteLine("1. AC");
                Console.WriteLine("2. Fan");
                Console.WriteLine("3. Light");
                Console.WriteLine("4. Show Every Appliance Status");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                    break;
                if (choice == 4)
                {
                    foreach (Appliance appliance in appliances)
                    {
                        IControllable d = (IControllable)appliance;
                        Console.WriteLine(appliance);
                        d.DisplayDetails();
                    }
                    break;
                }
                

                Console.WriteLine("1. Turn ON");
                Console.WriteLine("2. Turn OFF");
                Console.WriteLine("3. Show Status");
                int choice2 = int.Parse(Console.ReadLine());

                IControllable device = (IControllable)appliances[choice- 1];

                switch(choice2)
                {
                    case 1:
                        Console.WriteLine(appliances[choice]);
                        device.TurnOnAppliance();
                        break;

                    case 2:
                        device.TurnOffAppliance();
                        break;

                    case 3:
                        device.DisplayDetails();
                        break;
                }
            }
        }
    }
}
