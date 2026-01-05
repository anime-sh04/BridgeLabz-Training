using System;
using System.Collections.Generic;

class Patient{
    public string Name;
    public Patient(string name){
        Name= name;
    }
}

class Doctor{
    public string Name;
    private List<Patient> patients =new List<Patient>();

    public Doctor(string name){
        Name =name;
    }

    public void Consult(Patient p){
        patients.Add(p);
        Console.WriteLine("Dr." + Name+" is consulting patient "+ p.Name);
    }
}

class Hospital{
    public string HospitalName;
    public List<Doctor> doctors = new List<Doctor>();
    public List<Patient> patients = new List<Patient>();

    public Hospital(string name){
        HospitalName = name;
    }

    public void AddDoctor(Doctor d){
        doctors.Add(d);
    }

    public void AddPatient(Patient p){
        patients.Add(p);
    }
}

class HospitalAndDoctor{
    static void Main(string[] args){
        Hospital h = new Hospital("City Hospital");

        Doctor d1 = new Doctor("Verma");
        Doctor d2 = new Doctor("Singh");

        Patient p1 = new Patient("Rahul");
        Patient p2 = new Patient("Neha");

        h.AddDoctor(d1);
        h.AddDoctor(d2);
        h.AddPatient(p1);
        h.AddPatient(p2);

        d1.Consult(p1);
        d1.Consult(p2);
        d2.Consult(p1);
    }
}
