using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal interface ITrackable
    {
        void StartWorkout();
        void CalculateCalories();
    }
}
