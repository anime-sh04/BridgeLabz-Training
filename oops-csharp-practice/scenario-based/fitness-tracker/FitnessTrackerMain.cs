using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class FitnessTrackerMain
    {
        static void Main(string[] args)
        {
            UserProfile user1 = new UserProfile("Animesh", 21, 55.2, 170.3);

            user1.DisplayDetails();
            ITrackable w = new CardioWorkout("Running", 30, 100, 50);
            w.StartWorkout();
            w.CalculateCalories();
            ITrackable w2 = new StrengthWorkout("Weight Lifting", 30, 10, 100);
            w2.StartWorkout();
            w2.CalculateCalories();
        }
    }
}
