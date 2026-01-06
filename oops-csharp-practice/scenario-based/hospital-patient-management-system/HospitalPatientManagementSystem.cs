using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class HospitalPatientManagementSystem
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor("Dr. Sahil", "Cancer");

            Doctor d2 = new Doctor("Dr. Chirag", "Heart");
            Patient p1 = new InPatient("Animesh", "P2421", 22, 5,200.2,d1);
            Patient p2 = new InPatient("Afifa", "P284", 20, 2, 224,d1);

            Patient p3 = new OutPatient("Afifa", "P284", 20,2000.12, d2);

            p1.DisplayDetails();
            p2.DisplayDetails();
            p3.DisplayDetails();
        }
    }
