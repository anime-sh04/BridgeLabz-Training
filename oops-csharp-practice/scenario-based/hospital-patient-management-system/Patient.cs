using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_VS
{
    internal class Patient
    {
        string PatientName { get; set; }
        string PatientId { get; set; }
        int PatientAge { get; set; }
        public Doctor AssignedDoctor { get; set; }

        public Patient(string patientName, string patientId,int patientAge,Doctor doctor)
        {
            this.AssignedDoctor = doctor;
            this.PatientName = patientName;
            this.PatientId = patientId;
            this.PatientAge = patientAge;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Assigned Doctor : " + AssignedDoctor.DoctorName);
            Console.WriteLine("Doctor Category: " + AssignedDoctor.DoctorId);
            Console.WriteLine("Patient Name : "+ PatientName);
            Console.WriteLine("Patient ID : "+ PatientId);
            Console.WriteLine("Patient Age : " + PatientAge);
        }
    }
}
