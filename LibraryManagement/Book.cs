using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{

    public enum BookStatus
    {
        Available,
        Borrowed,
        Lost,
        Damaged
    }

    class Book
    {
        public Book(string title, string author, int isbn, int publishyear)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            PublishYear = publishyear;
            Status = BookStatus.Available;
        }

       
        public int Isbn { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }

        public BookStatus Status { get; set; }

        


    }
}
