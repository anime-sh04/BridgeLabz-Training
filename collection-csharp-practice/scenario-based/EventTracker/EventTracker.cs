using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

public class EventTracker
{
    public static void GenerateAuditLogs(Type type)
    {
        List<AuditLog> logs = new List<AuditLog>();

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        foreach (MethodInfo method in methods)
        {
            if (method.IsDefined(typeof(AuditTrailAttribute), false))
            {
                var audit = (AuditTrailAttribute)
                    method.GetCustomAttribute(typeof(AuditTrailAttribute));

                logs.Add(new AuditLog
                {
                    Action = audit.ActionName,
                    Module = audit.Module,
                    MethodName = method.Name,
                    Timestamp = DateTime.Now
                });
            }
        }

        string jsonOutput = JsonSerializer.Serialize(
            logs,
            new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("=== AUTO GENERATED AUDIT LOGS ===\n");
        Console.WriteLine(jsonOutput);
    }
}
