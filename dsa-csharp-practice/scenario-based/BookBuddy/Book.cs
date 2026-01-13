using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal class Book
    {
        private string BookDetail;
        public Book(string bookDetail)
        {
            BookDetail = bookDetail;
        }
        public string BookTitle
        {
            get{return BookDetail.Split('-')[0];}
        }

        public string BookAuthor
        {
            get{return BookDetail.Split('-')[1];}
        }
        public override string ToString()
        {
            return ($"book title : {BookTitle} \nbook Author : {BookAuthor}");
        }
    }

}
