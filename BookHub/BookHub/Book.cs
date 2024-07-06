using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    public class Book
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Book(string imageURL, string title, string author, string genre, double price, int quantity)
        {
            ImageURL = imageURL;
            Title = title;
            Author = author;
            Genre = genre;
            Price = price;
            Quantity = quantity;
        }
    }
}
