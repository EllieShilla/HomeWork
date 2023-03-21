using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Circle : Shape
    {
        const double PI = 3.14;
        public Circle(string name) : base(name)
        {
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
