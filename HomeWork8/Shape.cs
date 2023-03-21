using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        protected Shape(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public abstract double Area();

        public int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }

        public abstract double Perimeter();
    }
}
