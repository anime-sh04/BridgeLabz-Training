using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class Workout
    {
        private string workoutname;
        private double duration;
        public string WorkoutName
        {
            get { return workoutname; } 
            set { workoutname = value; }
        }
        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public Workout(string workoutname, double duration)
        {
            this.workoutname = workoutname;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"Workout Name : {workoutname}\nDuration : {duration}";
        }

    }
}
