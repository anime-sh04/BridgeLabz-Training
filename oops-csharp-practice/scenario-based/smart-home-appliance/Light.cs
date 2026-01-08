using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Automation_System
{
    internal class Light : Appliance, IControllable
    {
        private bool isOn;
        public Light(string name) : base(name) { }
        public void TurnOnAppliance()
        {
            Console.WriteLine("Turned the Light On");
            isOn = true;
        }
        public void TurnOffAppliance()
        {
            Console.WriteLine("Turned the Light Off");
            isOn = false;
        }

        public void DisplayDetails()
        {
            if (isOn)
                Console.WriteLine("Light is On");
            else
                Console.WriteLine("Light is Off");
        }

    }
}
