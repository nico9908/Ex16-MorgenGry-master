using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class Book : Merchandise
    {
        private string title;
        private double price;

        public string Title { get { return title; } set { title = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Book(string itemId, string title, double price) //: base(itemId)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public Book(string itemId,string title) : 
            this (itemId,title,0)
        {

        }
        public Book(string itemId) :
            this (itemId,"",0)
        {

        }

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price;
        }
    }
}
