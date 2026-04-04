using System;

[AttributeUsage(AttributeTargets.Method)]
public class AuditTrailAttribute : Attribute
{
    public string ActionName { get; }
    public string Module { get; }

    public AuditTrailAttribute(string actionName, string module)
    {
        ActionName = actionName;
        Module = module;
    }
}
