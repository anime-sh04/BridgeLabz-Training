using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name, int age) : base(name, age) { }

        public void Fly()
        {
            System.Console.WriteLine(Name + " is Flying");
        }

        public void Swim()
        {
            System.Console.WriteLine(Name + " is swimming");
        }
    }
}
