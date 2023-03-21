using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Square : Shape
    {
        public Square(string name) : base(name)
        {
        }

        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}
