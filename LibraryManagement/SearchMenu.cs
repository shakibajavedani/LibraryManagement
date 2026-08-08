using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagement
{
    class SearchMenu
    {
        

        static void ShowBook(Book book)
        {
            Console.WriteLine($"Title: {book.Title} Author: {book.Author} Isbn: {book.Isbn} Date: {book.PublishYear}");
        }

        public void SearchMenuActivity(BookManager manager)
        {
            Console.Clear();
            Console.WriteLine("Search Menu: \n");
            Console.WriteLine("search by :");
            Console.WriteLine("1-by isbn");
            Console.WriteLine("2-by title");
            Console.WriteLine("3-by date");
            //  Console.WriteLine("4-back to main menu");


            int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                        SearchByIsbn(manager);
                         break;
                        }

                    case 2:
                       {
                        SearchByTitle(manager);
                        break;
                        }

                    case 3:
                        {
                        SearchByDate(manager);        
                        break;
                        }

                }

        }

        //search book by isbn
        public void SearchByIsbn(BookManager manager)
        {
            Console.Write("enter the isbn : ");
            int isbn = int.Parse(Console.ReadLine());
            Book found = manager.FindBookByIsbn(isbn);
            if (found != null)
            {
                ShowBook(found);
            }
            else
            {
                Console.WriteLine("book not found!");
            }
        }


        //search book by Title
        public void SearchByTitle(BookManager manager)
        {
            Console.Write("enter the Title : ");
            string title = Console.ReadLine();
            List<Book> booklist = manager.FindBookByTitle(title);
            if (booklist.Count == 0)
            {
                Console.WriteLine("book not found!");
            }
            else
            {
                foreach (Book book in booklist)
                {
                    ShowBook(book);
                }
            }
        }


        //search book by Date
        public void SearchByDate(BookManager manager)
        {
            Console.Write("enter the date : ");
            int date = int.Parse(Console.ReadLine());
            List<Book> booklist = manager.FindBookByPublishYear(date);
            if (booklist.Count == 0)
            {

                Console.WriteLine("book not found!");
            }
            else
            {
                foreach (Book book in booklist)
                {
                    ShowBook(book);
                }
            }

        }


    }
}
