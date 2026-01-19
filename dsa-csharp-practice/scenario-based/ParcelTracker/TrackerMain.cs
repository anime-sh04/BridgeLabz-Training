using System;

namespace ParcelTracker
{
    class TrackerMain
    {
        static void Main(string[] args)
        {
            TrackerMenu menu = new TrackerMenu();
            menu.ShowMenu();
        }
    }
}
