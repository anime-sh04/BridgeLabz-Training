using Service;
using System;

namespace Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallLogManager manager = new CallLogManager(10);

            manager.AddCallLog("234564321", "Class Cancelled");
            manager.AddCallLog("2345432", "Call drop");
            manager.AddCallLog("23454322", "Failed in Subject");
            manager.AddCallLog("23456543324", "C# Classes");

            manager.SearchByKeyword("Class");

            DateTime from = DateTime.Now.AddMinutes(-5);
            DateTime to = DateTime.Now;

            manager.FilterByTime(from,to);
        }
    }
}
