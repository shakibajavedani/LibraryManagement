using tamrin_list;

Library manager = new Library();


Console.WriteLine("what do you want to do");
Console.WriteLine("1-Add Book");
Console.WriteLine("2-remove by isbn");
Console.WriteLine("3-edit Book");
Console.WriteLine("4-search Book by isbn");


int choose1 = int.Parse(Console.ReadLine());

switch (choose1)
{
    case 1:
        {
            //add book
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

            break;
        }

    case 2:
        {
            //remove
            Console.Write("enter the isbn : ");
            int isbn = int.Parse(Console.ReadLine());

            manager.RemoveBook(isbn);

            break;
        }

    case 3:
        {
            //edit
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
                manager.EditTitleBook(isbn, newTitle);
                break;
                }

                case 2:
                    {
                        Console.Write("enter the new Author : ");
                        string newAuthorName = Console.ReadLine();
                        manager.EditTitleBook(isbn, newAuthorName);

                        break;
                    }

                case 3:
                    {
                        Console.Write("enter the new Title : ");
                        int newDate = int.Parse(Console.ReadLine());
                        manager.EditDateBook(isbn, newDate);

                        break;
                    }
            }
         



            break;
        }

    case 4:
        {
            //Search
            Console.Write("how you want to search :");
            Console.WriteLine("1-by isbn");
            Console.WriteLine("2-by title");
            Console.WriteLine("3-by date");

            int choose2 = int.Parse(Console.ReadLine());
            switch (choose2)
            {
                case 1:
                    {
                        Console.Write("enter the isbn : ");
                        int isbn = int.Parse(Console.ReadLine());
                        manager.SearchBookByIsbn(isbn);
                        break;
                    }

                case 2:
                    {
                        Console.Write("enter the Title : ");
                        string title = Console.ReadLine();
                        manager.SearchBookByTitle(title);
                        break;
                    }

                case 3:
                    {
                        Console.Write("enter the date : ");
                        int date = int.Parse(Console.ReadLine());
                        manager.SearchBookByDate(date);

                        break;

                    }

            }

            break;
        }
}
