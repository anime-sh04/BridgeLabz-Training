using System;

class TimeZones{
    static void Main(){
        DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentUtcTime, gmt);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentUtcTime, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentUtcTime, pst);

        Console.WriteLine("GMT : " + gmtTime);
        Console.WriteLine("IST : " + istTime);
        Console.WriteLine("PST : " + pstTime);
    }
}
