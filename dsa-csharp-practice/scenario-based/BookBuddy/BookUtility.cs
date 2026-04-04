using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookBuddy
{
    internal class BookUtility:IBook
    {
        private Book[] books;
        public void AddBook()
        {
            Console.WriteLine("Enter no. of books");
            int numberOfBooks = int.Parse(Console.ReadLine());
            books=new Book[numberOfBooks];
            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine("Enter book title and author name");
                string bookDetail = Console.ReadLine();
                books[i] = new Book(bookDetail);
            }
        }
        public void UpdateBook()
        {
            if (books == null)
            {
                Console.WriteLine("Add books first");
                return;
            }

            Console.WriteLine("Enter title to update:");
            string input = Console.ReadLine();

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].BookTitle.Contains(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter new Title-Author:");
                    string newDetail = Console.ReadLine();
                    books[i] = new Book(newDetail);
                    Console.WriteLine($"Book updated - \n{books[i]}\n");
                    return;
                }
            }

            Console.WriteLine("Book not found");
        }

        public void SortBooksAlphabetically()
        {
            if (books == null)
            {
                Console.WriteLine("Add books first");
                return;
            }

            for (int i = 0; i < books.Length - 1; i++)
            {
                for (int j = i + 1; j < books.Length; j++)
                {
                    if (string.Compare(books[i].BookTitle, books[j].BookTitle) > 0)
                    {
                        Book temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }

            Console.WriteLine("Books sorted alphabetically:");
        }

        public void SearchByAuthor()
        {
            if (books == null)
            {
                Console.WriteLine("Add books first");
                return;
            }

            Console.WriteLine("Enter author name:");
            string author = Console.ReadLine();

            foreach (Book book in books)
            {
                if (book.BookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(book);
                    return;
                }
            }
            Console.WriteLine("Book not found");

        }
         
        public void DisplayBooks()
        {
            if (books == null)
            {
                Console.WriteLine("Add books first");
                return;
            }
            foreach(Book book  in books)
            {
                Console.WriteLine(book);
            }

        }
    }
}
