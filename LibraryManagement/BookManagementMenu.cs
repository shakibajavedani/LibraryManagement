using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class BookManagementMenu
    {
        public void BookManagementActivity(BookManager manager)
        {
            Console.Clear();
            
            Console.WriteLine("Book Management Menu :\n");
            Console.WriteLine("what do you want to do");
            Console.WriteLine("1-Add Book");
            Console.WriteLine("2-delet book");
            Console.WriteLine("3-edit Book");
            Console.WriteLine("4-back to main menu");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        //add book
                        AddBook(manager);
                        break;
                    }

                case 2:
                    {
                        // remove
                        Remove(manager);
                        break;
                    }

                case 3:
                    {
                        //edit
                        Edit(manager);
                        break;
                    }
                case 4:
                    {
                        return;
                        break;
                    }
            }

        }
        


        //add book
        public void AddBook(BookManager manager)
        {
            Console.Write("enter the Title of book : ");
            string title = Console.ReadLine();


            Console.Write("enter the Author of book : ");
            string author = Console.ReadLine();


            Console.Write("enter the ISBN of book : ");
            int isbn = int.Parse(Console.ReadLine());


            Console.Write("enter the Date of book : ");
            int date = int.Parse(Console.ReadLine());

            Book book = new Book(title, author, isbn, date);

            manager.AddBook(book);

        }



        // remove
        public void Remove(BookManager manager)
        {
            Console.Write("Enter the ISBN: ");
            int isbn = int.Parse(Console.ReadLine());

            if (manager.RemoveBook(isbn))
            {
                Console.WriteLine("Book removed from list.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }



        //edit
        public void Edit(BookManager manager)
        {
            Console.Write("wich one do you need  to edit : ");
            Console.Write("1-edit title ");
            Console.Write("2-edit author name");
            Console.Write("3-edit date");
            int edit = int.Parse(Console.ReadLine());

            Console.Write("enter the isbn of the book: ");
            int isbn = int.Parse(Console.ReadLine());

            switch (edit)
            {
                case 1:
                    {
                        Console.Write("enter the new Title : ");
                        string newTitle = Console.ReadLine();
                        if (manager.EditTitleBook(isbn, newTitle))
                        {
                            Console.WriteLine("Book title updated.");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    }

                case 2:
                    {
                        Console.Write("enter the new Author : ");
                        string newAuthorName = Console.ReadLine();

                        if (manager.EditAuthorBook(isbn, newAuthorName))
                        {
                            Console.WriteLine("Book author name updated.");
                        }

                        else { Console.WriteLine("Book not found."); }

                        break;
                    }

                case 3:
                    {
                        Console.Write("enter the new date : ");
                        int newDate = int.Parse(Console.ReadLine());
                        if (manager.EditDateBook(isbn, newDate))
                        { Console.WriteLine("Book date updated."); }
                        else
                        { Console.WriteLine("Book not found."); }

                        break;
                    }
            }
        }
    }
}
        








