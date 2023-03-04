using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Drink
    {
        private string title;
        private double price;

        public Drink(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public string Title { get { return title; } }

        public string PrintTitleAndPrice()
        {
            return $"Title: {title} Price: {price}";
        }
    }
}
