using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Eagle : Bird, IFlyable
    {
        public Eagle(string name, int age) : base(name, age) { }

        public void Fly()
        {
            System.Console.WriteLine(Name + " is Flying");
        }
    }
}
