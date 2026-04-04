using System;

class HealthCheckerMain
{
    static void Main()
    {
        Console.WriteLine("=== HealthCheckPro – API Metadata Validator ===\n");

        HealthCheckerPro.ScanController(typeof(LabTestController));
    }
}
