using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Duck : Bird, ISwimmable
    {
        public Duck(string name, int age) : base(name, age) { }

        public void Swim()
        {
            System.Console.WriteLine(Name+" is swimming");
        }
    }
}
