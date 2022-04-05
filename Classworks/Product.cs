using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    abstract class Product
    {

        private static int _id;
        public int Id {
            get 
            {
                return _id;
            }
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalInCome { get; protected set;}

        public Product(string name,int price,int count, int totalincome)
        {
            _id++;
            _id = Id;
            Name = name;
            Price = price;
            Count = count;
            TotalInCome = totalincome;
            

        }
        public abstract void Sell();
        public abstract void ShowInfo();


    }
}
