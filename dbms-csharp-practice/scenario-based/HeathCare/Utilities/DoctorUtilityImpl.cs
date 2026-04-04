using Microsoft.Data.SqlClient;
class DoctorUtilityImpl : IDoctor
{
    public void RecordPatientVisit()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Appointment Id: ");
        int apptId = int.Parse(Console.ReadLine());

        Console.Write("Enter Diagnosis: ");
        string diagnosis = Console.ReadLine();

        Console.Write("Enter Prescription: ");
        string prescription = Console.ReadLine();

        Console.Write("Enter Notes: ");
        string notes = Console.ReadLine();

        try
        {
            SqlCommand cmd = new SqlCommand("RecordPatientVisit", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ApptId", apptId);
            cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
            cmd.Parameters.AddWithValue("@Prescription", prescription);
            cmd.Parameters.AddWithValue("@Notes", notes);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Visit recorded successfully.");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Failed: " + ex.Message);
        }
    }
    public void ViewPatientMedicalHistory()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Patient Id: ");
        int patientId = int.Parse(Console.ReadLine());

        string query = @"
            SELECT 
                v.VisitDate,
                v.Diagnosis,
                v.Notes,
                p.MedicineName,
                p.Dosage,
                p.Duration
            FROM Visits v
            INNER JOIN AppointmentDetails a
                ON v.ApptId = a.ApptId
            LEFT JOIN Prescriptions p
                ON v.VisitId = p.VisitId
            WHERE a.PatientId = @PatientId
            ORDER BY v.VisitDate DESC";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@PatientId", patientId);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No medical history found.");
            reader.Close();
            return;
        }

        Console.WriteLine("\nPatient Medical History:");
        Console.WriteLine("--------------------------------------");

        while (reader.Read())
        {
            Console.WriteLine($"Visit Date : {reader["VisitDate"]}");
            Console.WriteLine($"Diagnosis  : {reader["Diagnosis"]}");
            Console.WriteLine($"Notes      : {reader["Notes"]}");
            Console.WriteLine($"Medicine   : {reader["MedicineName"]}");
            Console.WriteLine($"Dosage     : {reader["Dosage"]}");
            Console.WriteLine($"Duration   : {reader["Duration"]}");
            Console.WriteLine("--------------------------------------");
        }

        reader.Close();
    }

    public void AddPrescriptionDetails()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Visit Id: ");
        int visitId = int.Parse(Console.ReadLine());

        Console.Write("How many medicines to add? ");
        int count = int.Parse(Console.ReadLine());

        string query = @"
            INSERT INTO Prescriptions
            (VisitId, MedicineName, Dosage, Duration)
            VALUES
            (@VisitId, @MedicineName, @Dosage, @Duration)";

        using SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nMedicine {i + 1}");

                Console.Write("Medicine Name: ");
                string name = Console.ReadLine();

                Console.Write("Dosage: ");
                string dosage = Console.ReadLine();

                Console.Write("Duration: ");
                string duration = Console.ReadLine();

                SqlCommand cmd = new SqlCommand(query, connection, transaction);
                cmd.Parameters.AddWithValue("@VisitId", visitId);
                cmd.Parameters.AddWithValue("@MedicineName", name);
                cmd.Parameters.AddWithValue("@Dosage", dosage);
                cmd.Parameters.AddWithValue("@Duration", duration);

                cmd.ExecuteNonQuery();
            }

            transaction.Commit();
            Console.WriteLine("Prescriptions added successfully.");
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            Console.WriteLine("Failed: " + ex.Message);
        }
    }
}