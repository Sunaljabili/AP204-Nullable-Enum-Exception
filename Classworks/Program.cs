using Models;
using System;

namespace Classworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Victorya", 100, "Yuxulu", 50,3,60);
            Book book1 = new Book("Victorya", 100, "Yuxulu", 50,3,60);
            Book book3 = new Book("Victorya", 100, "Yuxulu", 50,3,60);
            book.Sell();
            book.Sell();
            book.Sell();
            book.Sell();
            Library lib = new Library();
            //Console.WriteLine(lib.AddBook(book));
            book.ShowInfo();

        }
    }
}
