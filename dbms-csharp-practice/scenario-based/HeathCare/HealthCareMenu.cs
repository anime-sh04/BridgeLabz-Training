using Microsoft.Identity.Client;

class HealthCareMenu
{
    ReceptionistUtilityImpl receptionist = new ReceptionistUtilityImpl();
    ReceptionistAndDoctor patientService = new ReceptionistAndDoctor();
    AdministratorUtilityImpl administrator = new AdministratorUtilityImpl();
    PatientAndReceptionistService patientAndReceptionist = new PatientAndReceptionistService();
    DoctorUtilityImpl doctor = new DoctorUtilityImpl();
    ReceptionistAndAdministratorService receptionistAndAdministrator = new ReceptionistAndAdministratorService();
    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("1. Receptionist");
            Console.WriteLine("2. Doctor");
            Console.WriteLine("3. Administrator");
            Console.WriteLine("4. Patient");
            Console.WriteLine("0. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0)
            {
                Console.WriteLine("Thankyou for using our service!");
                return;
            }
            switch (choice)
            {
                case 1: receptionistMenu();break;
                case 2: doctorMenu();break;
                case 3: administratorMenu();break;
                case 4: patientMenu();break;
                default: Console.WriteLine("Invalid Choice");break;
            }
        }
    }
    public void receptionistMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Add new Patient");
            Console.WriteLine("2. Update Patient");
            Console.WriteLine("3. Search Patient");
            Console.WriteLine("4. Search  Doctor By speciality");
            Console.WriteLine("5. Book Appointment for a Patient");
            Console.WriteLine("6. Check doctor Availability");
            Console.WriteLine("7. Cancel Appointment");
            Console.WriteLine("8. View Daily Appointment Schedule");
            Console.WriteLine("9. Generate Bill");
            Console.WriteLine("10. Record Payment");
            Console.WriteLine("11. View Outstanding Bills");
            Console.WriteLine("0. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0)
            {
                return;
            }
            switch (choice)
            {
                case 1: receptionist.AddNewPatient();break;
                case 2: receptionist.UpdatePatient();break;
                case 3: patientService.SearchPatient();break;
                case 4: receptionist.ViewDoctorBySpeciality();break;
                case 5: receptionist.BookAppointment();break;
                case 6: receptionist.CheckDoctorAvailability();break;
                case 7: patientAndReceptionist.CancelAppointment();break;
                case 8: patientService.ViewDailySchedule();break;
                case 9: receptionist.GenerateBill();break;
                case 10: receptionist.RecordPayment();break;
                case 11: receptionistAndAdministrator.ViewOutstandingBills();break;
                default: Console.WriteLine("Invalid Choice");break;
            }
        }
    }
    public void doctorMenu()
    {
        while(true){
            Console.WriteLine("1.Search Patient");
            Console.WriteLine("2. View Daily Appointment Schedule");
            Console.WriteLine("3. Record Patient Visit");
            Console.WriteLine("4. View Patient Medical History");
            Console.WriteLine("5. Add Prescription Details");
            Console.WriteLine("0. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if(choice ==0)
            {
                return;
            }
            switch (choice)
            {
                case 1:patientService.SearchPatient();break;
                case 2: patientService.ViewDailySchedule();break;
                case 3: doctor.RecordPatientVisit();break;
                case 4: doctor.ViewPatientMedicalHistory();break;
                case 5: doctor.AddPrescriptionDetails();break;
                default:Console.WriteLine("Invalid Choice");break;
            }
        }
    }   
    public void administratorMenu()
    {
        while(true){
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Doctor By speciality");
            Console.WriteLine("3. Deactivate Doctor Profile");
            Console.WriteLine("4. Generate Revenue Report");
            Console.WriteLine("5. Manage Speciality");
            Console.WriteLine("6. View Audit Logs");
            Console.WriteLine("7. View Outstanding Bills");
            Console.WriteLine("0. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0)
            {
                return;
            }
            switch (choice)
            {
                case 1: administrator.AddDoctor();break;
                case 2: administrator.UpdateDoctor();break;
                case 3: administrator.DeactivateDoctor();break;
                case 4: administrator.GenerateRevenueReport();break;
                case 5: specialityLookup();break;
                case 6: administrator.ViewAuditLogs();break;
                case 7: receptionistAndAdministrator.ViewOutstandingBills();break;
                default:Console.WriteLine("Invalid Choice");break;
            }
        }
    }
    public void specialityLookup()
    {
        while (true)
        {
            Console.WriteLine("1. Add Speciality");
            Console.WriteLine("2. View Speciality");
            Console.WriteLine("3. Update Speciality");
            Console.WriteLine("4. Delete Speciality");
            Console.WriteLine("0. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0)
            {
                return;
            }
            switch (choice)
            {
                case 1: administrator.AddSpeciality();break;
                case 2: administrator.ViewSpecialities();break;
                case 3: administrator.UpdateSpeciality();break;
                case 4: administrator.DeleteSpeciality();break;
                default:Console.WriteLine("Invalid Choice");break;
            }
        }
    }
    public void patientMenu()
    {
        while(true){
            Console.WriteLine("1. Cancel Appointment");
            Console.WriteLine("0. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0)
            {
                return;
            }
            switch (choice)
            {
                case 1: patientAndReceptionist.CancelAppointment();break;
                default:Console.WriteLine("Invalid Choice");break;
            }
        }
        
    }
}