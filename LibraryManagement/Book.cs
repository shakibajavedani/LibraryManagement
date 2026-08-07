using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_list
{
    class Book
    {
        public Book(string title, string author, int isbn, int publishyear)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            PublishYear = publishyear;
        }

        public int Isbn { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }


    }
}
