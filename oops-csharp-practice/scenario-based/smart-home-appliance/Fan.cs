using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Automation_System
{
    internal class Fan : Appliance, IControllable
    {
        private bool isOn;
        public Fan(string name) : base(name) { }
        public void TurnOnAppliance()
        {
            Console.WriteLine("Turned the Fan On");
            isOn = true;
        }
        public void TurnOffAppliance()
        {
            Console.WriteLine("Turned the Fan Off");
            isOn = false;
        }

        public void DisplayDetails()
        {
            if (isOn)
                Console.WriteLine("Fan is On");
            else
                Console.WriteLine("Fan is Off");
        }

    }
}
