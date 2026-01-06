using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird[] birds = {new Eagle("EagleOne", 5),new Sparrow("Tiny", 1),new Duck("Ducky", 3),new Penguin("Pingo", 4),new Seagull("Sky", 2)};

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);

                if (bird is IFlyable flyer)
                {
                    flyer.Fly();
                }

                if (bird is ISwimmable swimmer)
                {
                    swimmer.Swim();
                }

                Console.WriteLine();
            }
        }
    }
}
