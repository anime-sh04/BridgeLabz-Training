using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Bird
    {
        public string Name;
        public int Age;

        public Bird(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age;
        }
    }
}
