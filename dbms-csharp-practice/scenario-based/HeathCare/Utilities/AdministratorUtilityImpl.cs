using System.Data;
using Microsoft.Data.SqlClient;

class AdministratorUtilityImpl : IAdministrator
{
    #pragma warning disable
    public void AddDoctor()
    {
        try{
            SqlConnection connection = HealthCareConnection.Connect();

            string DoctorName = Console.ReadLine();
            int SpecialityId = int.Parse(Console.ReadLine());
            long DoctorContact = long.Parse(Console.ReadLine());
            double DoctorFee = double.Parse(Console.ReadLine());
            string query = @"
            INSERT INTO DoctorDetails(DoctorName,SpecialityId,DoctorContact,DoctorFee) VALUES (@DoctorName,@SpecialityId,@DoctorContact,@DoctorFee);";

            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@DoctorName",DoctorName);
            cmd.Parameters.AddWithValue("@SpecialityId",SpecialityId);
            cmd.Parameters.AddWithValue("@DoctorContact",DoctorContact);
            cmd.Parameters.AddWithValue("@DoctorFee",DoctorFee);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Doctor Added Successfully!");
            connection.Close();
        }

        catch (SqlException ex) when (ex.Number == 547)
        {
            Console.WriteLine("Invalid Speciality ID.");
        }
    }
    public void UpdateDoctor()
    {
        using SqlConnection connection = HealthCareConnection.Connect();
    
        SqlCommand cmd = new SqlCommand(
            "SELECT DoctorId, DoctorName FROM DoctorDetails WHERE DoctorIsActive = 1",
            connection);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No Doctor found!");
            reader.Close();
            return;
        }

        Console.WriteLine("Available Doctors:");
        while (reader.Read())
        {
            Console.WriteLine($"{reader["DoctorId"]} - {reader["DoctorName"]}");
        }
        reader.Close();

        Console.Write("Enter Doctor Id to change speciality: ");
        int doctorIdToChange = int.Parse(Console.ReadLine());

        SqlCommand cmd2 = new SqlCommand(
            "SELECT SpecialityId, SpecialityName FROM Speciality",
            connection);

        SqlDataReader reader2 = cmd2.ExecuteReader();

        Console.WriteLine("Available Specialities:");
        while (reader2.Read())
        {
            Console.WriteLine($"{reader2["SpecialityId"]} - {reader2["SpecialityName"]}");
        }
        reader2.Close();

        Console.Write("Enter new Speciality Id: ");
        int specialityToChange = int.Parse(Console.ReadLine());

        try
        {
            SqlCommand spCmd = new SqlCommand(
                "UpdateDoctorSpeciality", connection);

            spCmd.CommandType = CommandType.StoredProcedure;
            spCmd.Parameters.AddWithValue("@DoctorId", doctorIdToChange);
            spCmd.Parameters.AddWithValue("@SpecialityId", specialityToChange);

            spCmd.ExecuteNonQuery();
            Console.WriteLine("Doctor speciality updated successfully!");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Update failed: " + ex.Message);
        }
    }

    public void DeactivateDoctor()
    {
        using SqlConnection connection = HealthCareConnection.Connect();
    
        string fetchDoctors = @"
            SELECT DoctorId, DoctorName 
            FROM DoctorDetails 
            WHERE DoctorIsActive = 1";

        SqlCommand fetchCmd = new SqlCommand(fetchDoctors, connection);
        SqlDataReader reader = fetchCmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No active doctors found.");
            reader.Close();
            return;
        }

        Console.WriteLine("Active Doctors:");
        while (reader.Read())
        {
            Console.WriteLine($"{reader["DoctorId"]} - {reader["DoctorName"]}");
        }
        reader.Close();

        Console.Write("\nEnter Doctor Id to deactivate: ");
        int doctorId = int.Parse(Console.ReadLine());

        SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            string checkAppointments = @"
                SELECT COUNT(*) 
                FROM AppointmentDetails
                WHERE DoctorId = @DoctorId
                  AND ApptDate > CAST(GETDATE() AS DATE)
                  AND Status = 'SCHEDULED'";

            SqlCommand checkCmd = new SqlCommand(checkAppointments, connection, transaction);
            checkCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            int futureAppointments = (int)checkCmd.ExecuteScalar();

            if (futureAppointments > 0)
            {
                throw new HealthCareException("Doctor has future appointments and cannot be deactivated.");
            }

            string deactivateDoctor = @"
                UPDATE DoctorDetails
                SET DoctorIsActive = 0
                WHERE DoctorId = @DoctorId";

            SqlCommand deactivateCmd = new SqlCommand(deactivateDoctor, connection, transaction);
            deactivateCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            int rows = deactivateCmd.ExecuteNonQuery();
            if (rows == 0)
            {
                throw new HealthCareException("Doctor not found.");
            }

            transaction.Commit();
            Console.WriteLine("Doctor deactivated successfully.");
        }
        catch (HealthCareException ex)
        {
            transaction.Rollback();
            Console.WriteLine("Deactivation failed: " + ex.Message);
        }
    }

    public void GenerateRevenueReport()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Start Date (yyyy-MM-dd): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter End Date (yyyy-MM-dd): ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        string query = @"
            SELECT 
                d.DoctorName,
                s.SpecialityName,
                SUM(b.TotalAmount) AS TotalRevenue
            FROM Bills b
            INNER JOIN Visits v
                ON b.VisitId = v.VisitId
            INNER JOIN AppointmentDetails a
                ON v.ApptId = a.ApptId
            INNER JOIN DoctorDetails d
                ON a.DoctorId = d.DoctorId
            INNER JOIN Speciality s
                ON d.SpecialityId = s.SpecialityId
            WHERE b.PaymentStatus = 'PAID'
              AND b.BillDate BETWEEN @StartDate AND @EndDate
            GROUP BY d.DoctorName, s.SpecialityName
            HAVING SUM(b.TotalAmount) > 1000
            ORDER BY TotalRevenue DESC";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@StartDate", startDate);
        cmd.Parameters.AddWithValue("@EndDate", endDate);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No revenue data found.");
            reader.Close();
            return;
        }

        Console.WriteLine("\nRevenue Report:");
        Console.WriteLine("------------------------------------");

        while (reader.Read())
        {
            Console.WriteLine($"Doctor      : {reader["DoctorName"]}");
            Console.WriteLine($"Speciality  : {reader["SpecialityName"]}");
            Console.WriteLine($"Revenue     : {reader["TotalRevenue"]}");
            Console.WriteLine("------------------------------------");
        }

        reader.Close();
    }

    public void AddSpeciality()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Speciality Name: ");
        string name = Console.ReadLine();

        string query = "INSERT INTO Speciality (SpecialityName) VALUES (@Name)";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Name", name);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Speciality added successfully.");
    }
    public void ViewSpecialities()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        string query = "SELECT * FROM Speciality";

        SqlCommand cmd = new SqlCommand(query, connection);
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"{reader["SpecialityId"]} - {reader["SpecialityName"]}");
        }

        reader.Close();
    }
    public void UpdateSpeciality()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Speciality Id to update: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter New Name: ");
        string newName = Console.ReadLine();

        string query = @"
            UPDATE Speciality
            SET SpecialityName = @Name
            WHERE SpecialityId = @Id";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Name", newName);
        cmd.Parameters.AddWithValue("@Id", id);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Speciality updated successfully.");
    }
    public void DeleteSpeciality()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Speciality Id to delete: ");
        int id = int.Parse(Console.ReadLine());

        string checkQuery = @"
            SELECT COUNT(*) 
            FROM DoctorDetails
            WHERE SpecialityId = @Id";

        SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
        checkCmd.Parameters.AddWithValue("@Id", id);

        int doctorCount = (int)checkCmd.ExecuteScalar();

        if (doctorCount > 0)
        {
            Console.WriteLine("Cannot delete. Speciality is assigned to doctors.");
            return;
        }

        string deleteQuery = "DELETE FROM Speciality WHERE SpecialityId = @Id";

        SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
        deleteCmd.Parameters.AddWithValue("@Id", id);

        deleteCmd.ExecuteNonQuery();
        Console.WriteLine("Speciality deleted successfully.");
    }

    public void ViewAuditLogs()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Table Name: ");
        string tableName = Console.ReadLine();

        Console.Write("Enter User Name: ");
        string user = Console.ReadLine();

        Console.Write("Enter Start Date (yyyy-MM-dd): ");
        DateTime start = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter End Date (yyyy-MM-dd): ");
        DateTime end = DateTime.Parse(Console.ReadLine());

        string query = @"
            SELECT *
            FROM Audit_Log
            WHERE TableName = @TableName
              AND ChangedBy = @User
              AND ChangeDate BETWEEN @Start AND @End
            ORDER BY ChangeDate DESC";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@TableName", tableName);
        cmd.Parameters.AddWithValue("@User", user);
        cmd.Parameters.AddWithValue("@Start", start);
        cmd.Parameters.AddWithValue("@End", end);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No audit logs found.");
            reader.Close();
            return;
        }

        Console.WriteLine("\nAudit Logs:");
        Console.WriteLine("--------------------------------");

        while (reader.Read())
        {
            Console.WriteLine($"Table      : {reader["TableName"]}");
            Console.WriteLine($"Operation  : {reader["OperationType"]}");
            Console.WriteLine($"Record ID  : {reader["RecordId"]}");
            Console.WriteLine($"Changed By : {reader["ChangedBy"]}");
            Console.WriteLine($"Date       : {reader["ChangeDate"]}");
            Console.WriteLine("--------------------------------");
        }
        reader.Close();
    }

}