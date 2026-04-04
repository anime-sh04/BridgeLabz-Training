using Microsoft.Data.SqlClient;

class ReceptionistAndDoctor : IPatientService
{
    public void SearchPatient()
    {
        Console.Write("Enter name/ID/phone: ");
        string patientToSearch = Console.ReadLine();
        SqlConnection connection = HealthCareConnection.Connect();
        string query = @"SELECT * FROM PatientDetails
            WHERE PatientName LIKE @NameSearch
            OR PatientId = TRY_CAST(@IdSearch AS INT)
            OR PatientContact = TRY_CAST(@ContactSearch AS BIGINT)";

        SqlCommand cmd = new SqlCommand(query,connection);
        cmd.Parameters.AddWithValue("@NameSearch","%"+patientToSearch+"%");
        cmd.Parameters.AddWithValue("@IdSearch",patientToSearch);
        cmd.Parameters.AddWithValue("@ContactSearch",patientToSearch);

        SqlDataReader reader = cmd.ExecuteReader();
        if(reader.HasRows)
        {
            while (reader.Read())
            {
                Console.WriteLine("Patient Found!");
                Console.WriteLine("Patient ID     : " + reader["PatientId"]);
                Console.WriteLine("Patient Name   : " + reader["PatientName"]);
                Console.WriteLine("Patient Age    : " + reader["PatientDOB"]);
                Console.WriteLine("Patient Contact: " + reader["PatientContact"]);
                Console.WriteLine("Patient Contact: " + reader["PatientAddress"]);
                Console.WriteLine("Patient Contact: " + reader["PatientBloodGroup"]);
                Console.WriteLine("----------------------------");
            }
        }
        else
        {
            Console.WriteLine("Patient Not Found!");
        }
        reader.Close();
        connection.Close();
        
   }
    public void ViewDailySchedule()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        string query = @"
            SELECT 
                a.ApptTime,
                p.PatientName,
                d.DoctorName,
                a.Status
            FROM AppointmentDetails a
            INNER JOIN PatientDetails p
                ON a.PatientId = p.PatientId
            INNER JOIN DoctorDetails d
                ON a.DoctorId = d.DoctorId
            WHERE a.ApptDate = @ApptDate
            ORDER BY a.ApptTime";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@ApptDate", date);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No appointments found for this date.");
            reader.Close();
            return;
        }

        Console.WriteLine("\nDaily Appointment Schedule:");
        Console.WriteLine("-------------------------------------------");

        while (reader.Read())
        {
            TimeSpan time = (TimeSpan)reader["ApptTime"];

            Console.WriteLine($"Time     : {time:hh\\:mm}");
            Console.WriteLine($"Patient  : {reader["PatientName"]}");
            Console.WriteLine($"Doctor   : {reader["DoctorName"]}");
            Console.WriteLine($"Status   : {reader["Status"]}");
            Console.WriteLine("-------------------------------------------");
        }

        reader.Close();
    }

}