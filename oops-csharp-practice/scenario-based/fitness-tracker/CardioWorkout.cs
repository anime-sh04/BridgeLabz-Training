using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class CardioWorkout:Workout,ITrackable
    {
        private double distance;
        private double speed;

        public double Distance { get { return distance; } set { distance = value; } }
        public double Speed { get { return speed; } set { speed = value; } }

        public CardioWorkout(string name, double duration, double distance, double speed) : base(name, duration)
        {
            this.distance = distance;
            this.speed = speed;
        }

        public void StartWorkout()
        {
            Console.WriteLine("\nStarting Workout!\nRunning..");
            Console.WriteLine(this);
        }
        public void CalculateCalories()
        {
            Console.WriteLine("\nTotal Calorie Burned : " + (distance * speed)*0.5);
        }
    }
}
