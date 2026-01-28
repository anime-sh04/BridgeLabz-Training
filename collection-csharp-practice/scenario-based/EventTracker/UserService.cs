public class UserService
{
    [AuditTrail("User Login", "Authentication")]
    public void Login(string username)
    {
        Console.WriteLine($"{username} logged in");
    }

    [AuditTrail("File Upload", "File Management")]
    public void UploadFile(string fileName)
    {
        Console.WriteLine($"{fileName} uploaded");
    }

    [AuditTrail("File Delete", "File Management")]
    public void DeleteFile(string fileName)
    {
        Console.WriteLine($"{fileName} deleted");
    }

    public void ViewProfile()
    {
        // ❌ Not audited
    }
}
