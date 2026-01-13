using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    class BookMenu
    {
        BookUtility utilities = new BookUtility();
        public void Menu()
        {
            Console.WriteLine("Enter your choice");
			
            while (true)
            {
                Console.WriteLine($"1.Add Books \n2.Sort Books \n3.Update book \n4.Search book \n5.Display books \n6.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utilities.AddBook();
                        break;
                    case 2:
                        utilities.SortBooksAlphabetically();
                        break;
                    case 3:
                        utilities.UpdateBook();
                        break;
                    case 4:
                        utilities.SearchByAuthor();
                        break;
                    case 5:
                        utilities.DisplayBooks();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
