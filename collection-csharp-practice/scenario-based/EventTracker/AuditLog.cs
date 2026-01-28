using System;

public class AuditLog
{
    public string Action { get; set; }
    public string Module { get; set; }
    public string MethodName { get; set; }
    public DateTime Timestamp { get; set; }
}
