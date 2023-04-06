using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>()
            {
                new Triangle(new Point(1,2),new Point(3,-4),new Point(-4,5)),
                new Triangle(new Point(2,3),new Point(1,6),new Point(2,4)),
                new Triangle(new Point(3,7),new Point(2,5),new Point(1,3))
            };

            foreach (Triangle triangle in triangles)
            {
                triangle.Print("Perimeter", triangle.Perimeter());
                triangle.Print("Square", triangle.Square());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
