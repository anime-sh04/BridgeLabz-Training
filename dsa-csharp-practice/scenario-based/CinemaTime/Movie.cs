using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Movie
    {
        private string title;
        private DateTime time;

        public string Title { get { return title; } set { title = value; }  }
        public DateTime Time { get { return time;} set { time = value; }  }

        public override string ToString()
        {
            return $"Title : {Title}\nTime : {Time.ToString("HH:mm")} hrs";
        }

    }
}
