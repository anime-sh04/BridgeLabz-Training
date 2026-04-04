using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Automation_System
{
    internal interface IControllable
    {
        void TurnOnAppliance();
        void TurnOffAppliance();
        void DisplayDetails();
    }
}
