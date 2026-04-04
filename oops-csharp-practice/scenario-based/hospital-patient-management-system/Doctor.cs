using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_VS
{
    internal class Doctor
    {
        public string DoctorName { get; set; }
        public string DoctorId { get; set; }

        public Doctor(string doctorName, string doctorId)
        {
            this.DoctorId = doctorId;
            this.DoctorName = doctorName;
        }
    }
}
