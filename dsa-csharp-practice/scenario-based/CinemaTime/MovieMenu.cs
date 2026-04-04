using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class MovieMenu
    {
        private IMovie Movie;

        public void Menu()
        {
            Movie = new MovieUtilites();
            while (true)
            {
                Console.WriteLine("1. Add Movie\n");
                Console.WriteLine("2. Search Movie\n");
                Console.WriteLine("3. Display Movies\n");
                Console.WriteLine("0. Exit\n");
                int choice = int.Parse(Console.ReadLine());

                
                if (choice == 0) return;
                switch (choice)
                {
                    case 1:
                        Movie.AddMovie();
                        break;
                    case 2:
                        Movie.SearchMovie();
                        break;
                    case 3:
                        Movie.DisplayMovies();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
