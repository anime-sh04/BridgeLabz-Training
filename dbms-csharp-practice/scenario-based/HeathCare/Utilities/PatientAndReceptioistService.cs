using Microsoft.Data.SqlClient;
class PatientAndReceptionistService
{
    public void CancelAppointment()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        Console.Write("Enter Appointment Id to cancel: ");
        int apptId = int.Parse(Console.ReadLine());

        Console.Write("Cancelled By (Patient/Receptionist): ");
        string cancelledBy = Console.ReadLine();

        SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            string checkQuery = @"
                SELECT COUNT(*) 
                FROM AppointmentDetails
                WHERE ApptId = @ApptId
                  AND Status = 'SCHEDULED'";

            SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction);
            checkCmd.Parameters.AddWithValue("@ApptId", apptId);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists == 0)
            {
                throw new Exception("Appointment not found or already cancelled.");
            }

            string updateQuery = @"
                UPDATE AppointmentDetails
                SET Status = 'CANCELLED'
                WHERE ApptId = @ApptId";

            SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction);
            updateCmd.Parameters.AddWithValue("@ApptId", apptId);
            updateCmd.ExecuteNonQuery();

            string auditQuery = @"
                INSERT INTO Appointment_Audit
                (ApptId, Action, OldStatus, NewStatus, ActionBy, ActionDate)
                VALUES
                (@ApptId, 'CANCELLED', 'SCHEDULED', 'CANCELLED', @ActionBy, GETDATE())";

            SqlCommand auditCmd = new SqlCommand(auditQuery, connection, transaction);
            auditCmd.Parameters.AddWithValue("@ApptId", apptId);
            auditCmd.Parameters.AddWithValue("@ActionBy", cancelledBy);
            auditCmd.ExecuteNonQuery();

            transaction.Commit();
            Console.WriteLine("Appointment cancelled successfully.");
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            Console.WriteLine("Cancellation failed: " + ex.Message);
        }
    }

}