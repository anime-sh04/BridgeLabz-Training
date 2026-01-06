using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_VS
{
    internal class InPatient:Patient
    {
        public int DaysAdmitted {  get; set; }
        public double DailyCharge { get; set; }

        public InPatient(string name, string id,int age,int daysadmitted,double dailyCharge, Doctor doctor)
            : base(name, id, age,doctor)
        {
            DaysAdmitted = daysadmitted;
            DailyCharge = dailyCharge;
        }

        public override void DisplayDetails()
        {

            Bill b1 = new Bill(DaysAdmitted,DailyCharge);
            base.DisplayDetails();
            Console.WriteLine("Number of Days Admitted : " + DaysAdmitted);
            Console.WriteLine("Daily Charge : " + DailyCharge);
            Console.WriteLine("Total Patient Bill : " + b1.CalculateCharge());
            Console.WriteLine();
        } 


    }
}
