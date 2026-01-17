using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class FitnessMenu
    {
        IFitness users = new FitnessUtilityImpl();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Display LeaderBoard");
                Console.WriteLine("3. Display Users");
                Console.WriteLine("0. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 0:
                        return;
                    case 1:users.AddUser();break;
                    case 2:users.DisplayWithBubbleSort();break;
                    case 3:users.Display();break;
                    default:Console.WriteLine("INvalid Choice");break;
                }
            }
        }   
    }
}
