using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal interface IBook
    {
        void AddBook();
        void UpdateBook();
        void SortBooksAlphabetically();
        void SearchByAuthor();
        void DisplayBooks();
    }

}
