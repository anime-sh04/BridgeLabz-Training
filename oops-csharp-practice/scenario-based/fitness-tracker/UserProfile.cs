using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class UserProfile
    {
        private string name;
        private int age;
        private double weight;
        private double height;

        public UserProfile(string name, int age, double weight, double height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name : {name}\nAge : {age}\nWeight : {weight}\nHeight : {height}");
        }
    }
}
