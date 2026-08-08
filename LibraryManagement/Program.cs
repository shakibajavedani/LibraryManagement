using LibraryManagement;
using static System.Reflection.Metadata.BlobBuilder;

//static void ShowBook(Book book)
//{
//    Console.WriteLine($"Title: {book.Title} Author: {book.Author} Isbn: {book.Isbn} Date: {book.PublishYear}");
//}

BookManager manager = new BookManager();
BookManagementMenu menu1 = new BookManagementMenu();
SearchMenu menu2 = new SearchMenu();

bool isrunning = true;

do
{

    Console.WriteLine("what do you want to do");
    Console.WriteLine("1-Open BookManagment Menu");
    Console.WriteLine("2-Open Search Menu ");
    Console.WriteLine("3-view/Filter Books ");
    Console.WriteLine("4-exit ");
   /* View / Filter Books
    ├── Show All
    ├── Show Available
    ├── Show Borrowed
    ├── Show Lost
    └── Show Damaged
   */
  
    int choose = int.Parse(Console.ReadLine());

    switch (choose)
    {
        case 1:
            {
                //BookManagementMenu open
                menu1.BookManagementActivity(manager);
                break;
            }

        case 2:
            {
                //Search Menu
                menu2.SearchMenuActivity(manager);
                
                break;
            }

        case 3:
            {
               
                break;
            }
    
        case 4:
            {
                isrunning = false;
                break;
            }
    }
}
while (isrunning);
