using System;

namespace HospitalSystem
{
    interface IMedicalRecord
    {
        void AddRecord(string diagnosis, string history);
        void ViewRecords();
    }

    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        private string diagnosis;
        private string medicalHistory;

        public int PatientId { get { return patientId; } }
        public string Name { get { return name; } }
        public int Age { get { return age; } }

        public Patient(int id, string name, int age)
        {
            patientId = id;
            this.name = name;
            this.age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID : " + PatientId);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
        }

        protected void SetMedicalData(string diag, string history)
        {
            diagnosis = diag;
            medicalHistory = history;
        }

        protected void ShowMedicalData()
        {
            Console.WriteLine("Diagnosis : " + diagnosis);
            Console.WriteLine("Medical History : " + medicalHistory);
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        private int daysAdmitted;
        private double dailyCharge;

        public InPatient(int id, string name, int age, int days, double charge)
            : base(id, name, age)
        {
            daysAdmitted = days;
            dailyCharge = charge;
        }

        public override double CalculateBill()
        {
            return daysAdmitted * dailyCharge;
        }

        public void AddRecord(string diagnosis, string history)
        {
            SetMedicalData(diagnosis, history);
        }

        public void ViewRecords()
        {
            ShowMedicalData();
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee;

        public OutPatient(int id, string name, int age, double fee)
            : base(id, name, age)
        {
            consultationFee = fee;
        }

        public override double CalculateBill()
        {
            return consultationFee;
        }

        public void AddRecord(string diagnosis, string history)
        {
            SetMedicalData(diagnosis, history);
        }

        public void ViewRecords()
        {
            ShowMedicalData();
        }
    }

    class Program
    {
        static void Main()
        {
            Patient[] patients = new Patient[2];

            patients[0] = new InPatient(101,"Animesh", 21, 5, 2000);
            patients[1] = new OutPatient(102, "Rahul", 30, 800);

            for (int i = 0; i < patients.Length; i++)
            {
                Patient p = patients[i];
                p.GetPatientDetails();

                if (p is IMedicalRecord)
                {
                    IMedicalRecord record = (IMedicalRecord)p;
                    record.AddRecord("Flu","No previous major illness");
                    record.ViewRecords();
                }

                Console.WriteLine("Total Bill: "+p.CalculateBill());
            }
        }
    }
}
