using Microsoft.Data.SqlClient;

class HealthCareConnection
{   
    private static string connectionString="Server=localhost\\SQLEXPRESS;Database=HealthCareManagement;Trusted_Connection=true;TrustServerCertificate=true;";
    public static SqlConnection Connect()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        
        return connection;
    }
}