using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demotemplate
{
    public class Book
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }
        
        public Book()
        {
            Name = "No name";
            Pages = 0;
            Price = 0;
        }
        public Book(string name, int pages, int price)
        {
            Name = name; Pages = pages; Price = price;
        }

        public override string ToString()
        {
            return Name + ": " + Pages + " pages --- $" + Price;
        }
    }
}