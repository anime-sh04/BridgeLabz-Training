using System;

namespace Encapsulation
{
    interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }

    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;
        private string borrower;

        public int ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }

        public LibraryItem(int id, string title, string author)
        {
            itemId = id;
            this.title = title;
            this.author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("Item ID : " + ItemId);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("Loan Duration : " + GetLoanDuration() + " days");
            Console.WriteLine("Available : " + (borrower == null));
        }

        protected void SetBorrower(string name)
        {
            borrower = name;
        }

        protected bool IsAvailable()
        {
            return borrower == null;
        }
    }

    class Book :LibraryItem,IReservable
    {
        public Book(int id, string title, string author)
         :base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem(string borrowerName)
        {
            if (IsAvailable())
            {
                SetBorrower(borrowerName);
                Console.WriteLine("Book reserved for " + borrowerName);
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    class Magazine : LibraryItem,IReservable
    {
        public Magazine(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem(string borrowerName)
        {
            if (IsAvailable())
            {
                SetBorrower(borrowerName);
                Console.WriteLine("Magazine reserved for " + borrowerName);
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    class DVD :LibraryItem,IReservable
    {
        public DVD(int id, string title, string author)
           :base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem(string borrowerName)
        {
            if (IsAvailable())
            {
                SetBorrower(borrowerName);
                Console.WriteLine("DVD reserved for " + borrowerName);
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    class Program
    {
        static void Main()
        {
            LibraryItem[] items = new LibraryItem[3];

            items[0] = new Book(1, "C#", "ASF2");
            items[1] = new Magazine(2, "Java", "WFG Team");
            items[2] = new DVD(3, "Inception", "WG3,.k Nolan");

            for (int i = 0; i < items.Length; i++)
            {
                items[i].GetItemDetails();
                if (items[i] is IReservable)
                {
                    IReservable r =(IReservable)items[i];

                    if(r.CheckAvailability())
                        r.ReserveItem("Animesh");
                }
            }
        }
    }
}
