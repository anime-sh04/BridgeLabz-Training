using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class MovieUtilites : IMovie
    {
        private Movie movie;
        Movie[] movies = new Movie[10];
        private int movieCount = 0;

        public Movie AddMovie()
        {
            if (movieCount >= movies.Length) { Console.WriteLine("Movie list is full"); return null; }

            Movie movie = new Movie();

            Console.Write("Enter title: ");
            movie.Title = Console.ReadLine();

            Console.Write("Enter hours: ");
            int hr = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int min = int.Parse(Console.ReadLine());

            movie.Time = new DateTime(1,1,1,hr,min,0);

            movies[movieCount] = movie;
            movieCount++;

            Console.WriteLine("Movie added successfully!");
            return movie;


        }
        public void SearchMovie()
        {
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();

            for (int i = 0; i < movieCount; i++)
            {
                if (movies[i].Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Found Movie:\n" + movies[i]);
                    return;
                }
            }

            Console.WriteLine("Movie Not Found");
        }
        public void DisplayMovies()
        {
            if (movieCount == 0)
            {
                Console.WriteLine("No movies to display");
                return;
            }

            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine(movies[i] + "\n");
            }
        }
    }
}
