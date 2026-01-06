using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Penguin : Bird, ISwimmable
    {
        public Penguin(string name, int age) : base(name, age) { }

        public void Swim()
        {
            System.Console.WriteLine(Name+" is swimming");
        }
    }
}
