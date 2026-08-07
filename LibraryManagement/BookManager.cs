using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagement
{
        class BookManager
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

            found.PublishYear = newDate;
            return true;
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

            public List<Book> FindBookByPublishYear(int date)
            {
            return books.FindAll(book=>book.PublishYear==date);
            }
        
    }

}

