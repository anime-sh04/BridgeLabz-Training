using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_VS
{

    internal class Bill :IPayable
    {
        public int NumberOfDays {  get; set; }
        public double DailyCharge { get; set; }

        public Bill(int days,double charge)
        {
            NumberOfDays = days;
            DailyCharge = charge;
        }
        public double CalculateCharge()
        {
            return NumberOfDays*DailyCharge;
        }

    }
}
