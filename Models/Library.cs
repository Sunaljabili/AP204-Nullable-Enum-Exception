using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Library
    {
        public int BookLimit;
        public Book[] books = new Book[0];
        public  Book[] AddBook(Book book)
        {
            if (books.Length > BookLimit)
            {
                foreach (var item in books)
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = item;

                }
            }
            else
            {
                throw new Exception("Mehsul bitibdi");
            }
            return books;
        }
        public Book[] GetBookById(int? id)
        {
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    return books;
                }
                
            }
            return null;
        }
    }
}
