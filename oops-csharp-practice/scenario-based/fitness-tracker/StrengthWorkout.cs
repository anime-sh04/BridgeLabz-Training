using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class StrengthWorkout:Workout,ITrackable
    {
        private int reps;
        private double weight;
        public int Reps { get { return reps; } set { reps = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public StrengthWorkout(string workoutname , double duration,int reps, double weight):base(workoutname, duration)
        {
            this.reps = reps;
            this.weight = weight;
        }
        public void StartWorkout()
        {
            Console.WriteLine("\nStarting Strength Workout!\n Doing Reps!");
            Console.WriteLine(this);
        }
        public void CalculateCalories()
        {
            Console.WriteLine("\nTotal Calorie Burned : " + (reps * weight)*0.1);
        }
    }
}
