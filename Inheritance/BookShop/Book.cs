using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                var indexOfSpace = value.IndexOf(' ');

                if (indexOfSpace > 0 && indexOfSpace < value.Length - 1 && char.IsDigit(value[indexOfSpace + 1]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }
        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");

                title = value;

            }
        }
        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");

                price = value;
            }
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name}" + Environment.NewLine +
                $"Title: {this.Title}" + Environment.NewLine +
                $"Author: {this.Author}" + Environment.NewLine +
                $"Price: {this.Price:f2}";
        }
    }
}
