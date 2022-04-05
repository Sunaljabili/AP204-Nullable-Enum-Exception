using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Book : Product
    {
        public string AuthorName;
        public int PageCount; 
        public Book(string authorname,int pagecount, string name, int price):base(name,price)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public override void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalInCome += Price;
            }
            else
            {
                Console.WriteLine("Mehsul qalmadi");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"AuthorName {AuthorName} PageCount: {PageCount}");
        }
    }
}
