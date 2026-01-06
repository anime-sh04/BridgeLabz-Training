using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_VS
{
    internal class OutPatient:Patient
    {
        public double Fee { get; set; }
        
        public OutPatient(string name, string id, int age, double fee, Doctor doctor)
            :base(name,id,age,doctor)
        {
            this.Fee = fee; 
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Your fee :" + Fee);
        }
    }
}
