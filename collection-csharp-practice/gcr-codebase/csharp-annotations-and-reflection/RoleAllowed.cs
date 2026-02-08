using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class SecureService
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted successfully!");
    }

    public void ViewUser()
    {
        Console.WriteLine("User details displayed.");
    }
}

class Program
{
    static void Main()
    {
        string currentUserRole = "USER"; 

        SecureService service = new SecureService();
        Type type = typeof(SecureService);
        #pragma warning disable
        MethodInfo method = type.GetMethod("DeleteUser");

        RoleAllowedAttribute attr =
            (RoleAllowedAttribute)Attribute.GetCustomAttribute(
                method, typeof(RoleAllowedAttribute));

        if (attr != null && attr.Role != currentUserRole)
        {
            Console.WriteLine("Access Denied!");
        }
        else
        {
            method.Invoke(service, null);
        }
    }
}
