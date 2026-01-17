using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class User
    {
        public string Name { get; set; }
        public int Steps {  get; set; }
        public User(string name , int steps)
        {
            Name = name;
            this.Steps = steps;
        }

        public override string? ToString()
        {
            return $"Name : {Name} - Total Steps :{Steps}";
        }
    }
}
