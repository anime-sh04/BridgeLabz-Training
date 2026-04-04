using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Automation_System
{
    internal abstract class Appliance
    {
        private string name;
        public string Name
        { get { return name; } 
        set { name = value; }}

        public Appliance(string name)
        {
            this.name = name; 
        }

        public override string? ToString()
        {
            return $"Appliance Name : {name}";
        }
    }
}
