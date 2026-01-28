using System;
using System.Reflection;

public class HealthCheckerPro
{
    public static void ScanController(Type controllerType)
    {
        Console.WriteLine($"Scanning Controller: {controllerType.Name}\n");

        MethodInfo[] methods = controllerType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        foreach (MethodInfo method in methods)
        {
            bool hasPublicApi = method.IsDefined(typeof(PublicAPIAttribute), false);
            bool hasAuth = method.IsDefined(typeof(RequiresAuthAttribute), false);

            if (!hasPublicApi && !hasAuth)
            {
                Console.WriteLine($"Missing API annotation: {method.Name}");
                continue;
            }

            if (hasPublicApi)
            {
                var api = (PublicAPIAttribute)method.GetCustomAttribute(typeof(PublicAPIAttribute));
                Console.WriteLine($"Public API: {method.Name}");
                Console.WriteLine($"Description: {api.Description}");
            }

            if (hasAuth)
            {
                var auth = (RequiresAuthAttribute)method.GetCustomAttribute(typeof(RequiresAuthAttribute));
                Console.WriteLine($"Secured API: {method.Name}");
                Console.WriteLine($"Role Required: {auth.Role}");
            }
        }
    }
}
