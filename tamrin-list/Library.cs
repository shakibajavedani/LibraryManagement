using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tamrin_list;
using static System.Net.Mime.MediaTypeNames;

namespace tamrin_list
{
        class Library
        {
            // ایجاد لیست
            List<Book> books = new List<Book>();

            //اضافه کردن کتاب به لیست
            public void AddBook(Book book)
            {
                books.Add(book);
            }

        //حذف کردن کتاب از لیست
        public bool RemoveBook(int isbn)
        {
            Book found = FindBookByIsbn(isbn);

            if (found == null)
            {
                return false;
            }

            books.Remove(found);
            return true;
        }

        //ادیت زدن اطلاعات لیست
        public bool EditTitleBook(int isbn,string newtitle)
        {
            Book found = FindBookByIsbn(isbn);
            if (found == null)
            {
                return false;
            }

            found.Title = newtitle;
            return true;
        }

        public bool EditAuthorBook(int isbn, string newauthor)
        {
            Book found = FindBookByIsbn(isbn);
            if (found == null)
            {
                return false;
            }

            found.Author = newauthor;
            return true;
        }

        public bool EditDateBook(int isbn, int newDate)
        {
            Book found = FindBookByIsbn(isbn);
            if (found == null)
            {
                return false;
            }

            found.Date = newDate;
            return true;
        }


        //سرچ زدن

        public void SearchBookByIsbn(int isbn)
            {
            Book found = FindBookByIsbn(isbn);

            if(found != null)
             {
                Console.WriteLine($"Title: {found.Title} Author: {found.Author} Isbn: {found.Isbn} Date: {found.Date}");
              }
            }

        public void SearchBookByTitle(string title)
        {
            List<Book> booklist = FindBookByTitle(title);
            if (booklist != null)
            {
                foreach (Book book in booklist)
                {
                    Console.WriteLine($"Title: {book.Title} Author: {book.Author} Isbn: {book.Isbn} Date: {book.Date}");
                }            
            }
        }

        public void SearchBookByDate(int date)
        {
            List<Book> booklist = FindBookByDate(date);
            if (booklist != null)
            {
                foreach (Book book in booklist)
                {
                    Console.WriteLine($"Title: {book.Title} Author: {book.Author} Isbn: {book.Isbn} Date: {book.Date}");
                }
            }
        }

            //توابع کمکی سرچ زدن 
            public Book FindBookByIsbn(int isbn)
            {
            return books.Find(book => book.Isbn == isbn);
            }

            public List<Book> FindBookByTitle(string title)
            {
            return books.FindAll(book=>book.Title==title);
            }

            public List<Book> FindBookByDate(int date)
            {
            return books.FindAll(book=>book.Date==date);
            }



            public void ShowBook()
            {
            }

        
    }

}

