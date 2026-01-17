using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class FitnessUtilityImpl : IFitness
    {
        User[] users = new User[20];
        int count = 0;

        public void AddUser()
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter number of steps : ");
            int steps = int.Parse(Console.ReadLine());
            users[count] = new User(name, steps);
            count++;
        }

        public void DisplayWithBubbleSort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (users[j].Steps > users[j + 1].Steps)
                    {
                        int temp = users[j].Steps;
                        users[j].Steps = users[j + 1].Steps;
                        users[j + 1].Steps = temp;


                        string tempName = users[j].Name;
                        users[j].Name = users[j + 1].Name;
                        users[j + 1].Name = tempName;
                    }
                }
            }

            Display();
        }

        public void Display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1} {users[i].Name} with {users[i].Steps}\n");
            }
        }
    }
}
