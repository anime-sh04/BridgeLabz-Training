using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal interface IMovie
    {
        Movie AddMovie();
        void SearchMovie();
        void DisplayMovies();
    }
}
