using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Automation_System
{
    internal class Ac : Appliance,IControllable
    {
        private bool isOn;
        public Ac(string name) : base(name) { }
        public void TurnOnAppliance()
        {
            Console.WriteLine("Turned the Ac On");
            isOn = true;
        }
        public void TurnOffAppliance()
        {
            Console.WriteLine("Turned the Ac Off");
            isOn = false;
        }

        public void DisplayDetails()
        {
            if(isOn)
                Console.WriteLine("Ac is On");
            else
                Console.WriteLine("Ac is Off");
        }

    }
}
