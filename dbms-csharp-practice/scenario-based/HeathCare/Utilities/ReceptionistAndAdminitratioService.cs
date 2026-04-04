using Microsoft.Data.SqlClient;
class ReceptionistAndAdministratorService
{
    public void ViewOutstandingBills()
    {
        using SqlConnection connection = HealthCareConnection.Connect();

        string query = @"
            SELECT 
                p.PatientId,
                p.PatientName,
                COUNT(b.BillId) AS UnpaidBillCount,
                SUM(b.TotalAmount) AS TotalOutstandingAmount
            FROM Bills b
            INNER JOIN Visits v
                ON b.VisitId = v.VisitId
            INNER JOIN AppointmentDetails a
                ON v.ApptId = a.ApptId
            INNER JOIN PatientDetails p
                ON a.PatientId = p.PatientId
            WHERE b.PaymentStatus = 'UNPAID'
            GROUP BY p.PatientId, p.PatientName
            ORDER BY TotalOutstandingAmount DESC";

        SqlCommand cmd = new SqlCommand(query, connection);

        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            Console.WriteLine("No outstanding bills found.");
            reader.Close();
            return;
        }

        Console.WriteLine("\nOutstanding Bills Summary:");
        Console.WriteLine("---------------------------------------------");

        while (reader.Read())
        {
            Console.WriteLine($"Patient ID   : {reader["PatientId"]}");
            Console.WriteLine($"Patient Name : {reader["PatientName"]}");
            Console.WriteLine($"Unpaid Bills : {reader["UnpaidBillCount"]}");
            Console.WriteLine($"Total Due    : {reader["TotalOutstandingAmount"]}");
            Console.WriteLine("---------------------------------------------");
        }

        reader.Close();
    }

}