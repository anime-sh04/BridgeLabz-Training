using System;

class EventTrackerMain
{
    static void Main()
    {
        Console.WriteLine("EventTracker – Auto Audit System\n");
        EventTracker.GenerateAuditLogs(typeof(UserService));
    }
}
