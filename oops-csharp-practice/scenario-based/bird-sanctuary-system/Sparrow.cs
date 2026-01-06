using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name, int age) : base(name, age) { }

        public void Fly()
        {
            Console.WriteLine(Name+ " is flying");
        }
    }
}
