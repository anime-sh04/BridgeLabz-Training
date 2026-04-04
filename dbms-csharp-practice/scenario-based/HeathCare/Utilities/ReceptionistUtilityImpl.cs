using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
class ReceptionistUtilityImpl : IReceptionist
{
    #pragma warning disable
    public void AddNewPatient()
    {
        Console.WriteLine("Enter Patient Name : ");
        string patientName = Console.ReadLine();
        Console.WriteLine("Enter Patient DOB (YYYY-MM-DD) : ");
        string patientDOB = Console.ReadLine();
        Console.WriteLine("Enter Patient Contact : ");
        long patientContact = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter Patient Address : ");
        string patientAddress = Console.ReadLine();
        Console.WriteLine("Enter Patient Blood Group : ");
        string patientBloodGroup = Console.ReadLine();
        
        using SqlConnection connection = HealthCareConnection.Connect();
        // connection.Open();
        string query = "INSERT INTO PatientDetails(PatientName,PatientDOB,PatientContact,PatientAddress,PatientBloodGroup) VALUES (@PatientName,@PatientDOB,@PatientContact,@PatientAddress,@PatientBloodGroup)";
        using SqlCommand cmd = new SqlCommand(query,connection);
        cmd.Parameters.AddWithValue("@PatientName", patientName);
        cmd.Parameters.AddWithValue("@PatientDOB", patientDOB);
        cmd.Parameters.AddWithValue("@PatientContact", patientContact);
        cmd.Parameters.AddWithValue("@PatientAddress", patientAddress);
        cmd.Parameters.AddWithValue("@PatientBloodGroup", patientBloodGroup);
        int n = cmd.ExecuteNonQuery();
        Console.WriteLine("Patient Added Successfully!");
        Console.WriteLine($"{n} rows affected");
        connection.Close();
    }
    
    public void UpdatePatient()
    {
        Console.WriteLine("Enter Contact of patient you want to search/update");
        long patientContactToSearch = long.Parse(Console.ReadLine());

        using SqlConnection connection= HealthCareConnection.Connect();
        string query = "SELECT * FROM PatientDetails WHERE PatientContact = @PatientContact;";
        using SqlCommand cmd = new SqlCommand(query,connection);
        cmd.Parameters.AddWithValue("@PatientContact",patientContactToSearch);
        using SqlDataReader reader = cmd.ExecuteReader();

        bool patientFound = false;
        int patientId  = 0;
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                patientId = (int)reader["PatientId"];
                Console.WriteLine("Patient ID     : " + reader["PatientId"]);
                Console.WriteLine("Patient Name   : " + reader["PatientName"]);
                Console.WriteLine("Patient Age    : " + reader["PatientDOB"]);
                Console.WriteLine("Patient Contact: " + reader["PatientContact"]);
                Console.WriteLine("Patient Contact: " + reader["PatientAddress"]);
                Console.WriteLine("Patient Contact: " + reader["PatientBloodGroup"]);
                Console.WriteLine("----------------------------");
                patientFound = true;
            }
        }
        else
        {
            Console.WriteLine("No patient found with this contact number");
        }
        reader.Close();
        if(patientFound){
            Console.WriteLine("Enter Patient Name : ");
            string patientName = Console.ReadLine();
            Console.WriteLine("Enter Patient DOB (YYYY-MM-DD) : ");
            string patientDOB = Console.ReadLine();
            Console.WriteLine("Enter Patient Contact : ");
            long patientContact = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient Address : ");
            string patientAddress = Console.ReadLine();
            Console.WriteLine("Enter Patient Blood Group : ");
            string patientBloodGroup = Console.ReadLine();

            string query2 = @"
                UPDATE PatientDetails
                SET PatientName = @PatientName,
                    PatientDOB = @PatientDOB,
                    PatientContact = @PatientContact,
                    PatientAddress = @PatientAddress,
                    PatientBloodGroup = @PatientBloodGroup
                WHERE PatientId = @PatientId;
                ";

            using SqlCommand cmd2 = new SqlCommand(query2,connection);
            
            cmd2.Parameters.AddWithValue("@PatientId", patientId);
            cmd2.Parameters.AddWithValue("@PatientName", patientName);
            cmd2.Parameters.AddWithValue("@PatientDOB", patientDOB);
            cmd2.Parameters.AddWithValue("@PatientContact", patientContact);
            cmd2.Parameters.AddWithValue("@PatientAddress", patientAddress);
            cmd2.Parameters.AddWithValue("@PatientBloodGroup", patientBloodGroup);
            int n = cmd2.ExecuteNonQuery();
            
            Console.WriteLine("Patient Updated Successfully!");
            Console.WriteLine($"{n} rows affected");
        }
        connection.Close();
    }
    public void ViewDoctorBySpeciality()
    {
        using SqlConnection connection = HealthCareConnection.Connect();
    
        string specQuery = "SELECT SpecialityName FROM Speciality";
        SqlCommand specCmd = new SqlCommand(specQuery, connection);
        SqlDataReader specReader = specCmd.ExecuteReader();

        Console.WriteLine("Available Specialities:");
        while (specReader.Read())
        {
            Console.WriteLine("- " + specReader["SpecialityName"]);
        }
        specReader.Close();

        Console.Write("\nEnter Speciality Name: ");
        string specialityName = Console.ReadLine();
        
        string query = @"
            SELECT 
                d.DoctorId,
                d.DoctorName,
                a.ApptDate,
                a.ApptTime,
                a.Status
            FROM DoctorDetails d
            INNER JOIN Speciality s
                ON d.SpecialityId = s.SpecialityId
            LEFT JOIN AppointmentDetails a
                ON d.DoctorId = a.DoctorId
            WHERE s.SpecialityName = @SpecialityName
              AND d.DoctorIsActive = 1
            ORDER BY d.DoctorName, a.ApptDate, a.ApptTime";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@SpecialityName", specialityName);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No doctors found for this speciality.");
            reader.Close();
            return;
        }

        Console.WriteLine("\nDoctors and Schedules:");
        Console.WriteLine("----------------------");

        while (reader.Read())
        {
            Console.WriteLine($"Doctor ID   : {reader["DoctorId"]}");
            Console.WriteLine($"Doctor Name : {reader["DoctorName"]}");
            Console.WriteLine($"Date        : {reader["ApptDate"]}");
            Console.WriteLine($"Time        : {reader["ApptTime"]}");
            Console.WriteLine($"Status      : {reader["Status"]}");
            Console.WriteLine("----------------------");
        }

        reader.Close();
    }
    public void BookAppointment()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Patient Id: ");
        int patientId = int.Parse(Console.ReadLine());

        Console.Write("Enter Doctor Id: ");
        int doctorId = int.Parse(Console.ReadLine());

        Console.Write("Enter Date (yyyy-MM-dd): ");
        DateTime apptDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Time (HH:mm): ");
        TimeSpan apptTime = TimeSpan.Parse(Console.ReadLine());

        try
        {
            SqlCommand cmd = new SqlCommand("BookAppointment", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PatientId", patientId);
            cmd.Parameters.AddWithValue("@DoctorId", doctorId);
            cmd.Parameters.AddWithValue("@ApptDate", apptDate);
            cmd.Parameters.AddWithValue("@ApptTime", apptTime);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Appointment booked successfully!");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Booking failed: " + ex.Message);
        }
    }
    public void CheckDoctorAvailability()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Doctor Id: ");
        int doctorId = int.Parse(Console.ReadLine());

        Console.Write("Enter Date (yyyy-MM-dd): ");
        DateTime apptDate = DateTime.Parse(Console.ReadLine());

        int maxCapacity = 5;

        string query = @"
            SELECT 
                ApptTime,
                COUNT(*) AS BookedSlots
            FROM AppointmentDetails
            WHERE DoctorId = @DoctorId
              AND ApptDate = @ApptDate
              AND Status = 'SCHEDULED'
            GROUP BY ApptTime
            ORDER BY ApptTime";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@DoctorId", doctorId);
        cmd.Parameters.AddWithValue("@ApptDate", apptDate);

        SqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine("\nSlot Availability:");

        if (reader.HasRows)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Time     | Booked | Available");
            Console.WriteLine("----------------------------");

            while (reader.Read())
            {
                TimeSpan time = (TimeSpan)reader["ApptTime"];
                int booked = (int)reader["BookedSlots"];
                int available = maxCapacity - booked;

                Console.WriteLine(
                    $"{time:hh\\:mm}  |   {booked}    |    {available}"
                );
            }

            reader.Close();
        }
        else
        {
            Console.WriteLine("\nDoctor have 0 appointments on this day. You can book!\n");
        }
    }
    public void RescheduleAppointment()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Appointment Id: ");
        int apptId = int.Parse(Console.ReadLine());

        Console.Write("Enter New Doctor Id: ");
        int doctorId = int.Parse(Console.ReadLine());

        Console.Write("Enter New Date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter New Time (HH:mm): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        try
        {
            SqlCommand cmd = new SqlCommand("RescheduleAppointment", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ApptId", apptId);
            cmd.Parameters.AddWithValue("@NewDoctorId", doctorId);
            cmd.Parameters.AddWithValue("@NewApptDate", date);
            cmd.Parameters.AddWithValue("@NewApptTime", time);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Appointment rescheduled successfully.");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Reschedule failed: " + ex.Message);
        }
    }

    public void GenerateBill()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Visit Id: ");
        int visitId = int.Parse(Console.ReadLine());

        try
        {
            SqlCommand cmd = new SqlCommand("GenerateBill", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@VisitId", visitId);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Bill generated successfully.");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Failed: " + ex.Message);
        }
    }

    public void RecordPayment()
    {
        using SqlConnection connection = HealthCareConnection.Connect();
    
        Console.Write("Enter Bill Id: ");
        int billId = int.Parse(Console.ReadLine());
    
        Console.Write("Enter Payment Mode (Cash/Card/UPI): ");
        string mode = Console.ReadLine();
    
        try
        {
            SqlCommand cmd = new SqlCommand("RecordPayment", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    
            cmd.Parameters.AddWithValue("@BillId", billId);
            cmd.Parameters.AddWithValue("@PaymentMode", mode);
    
            cmd.ExecuteNonQuery();
            Console.WriteLine("Payment recorded successfully.");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Payment failed: " + ex.Message);
        }
    }
    
}