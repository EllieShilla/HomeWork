using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task a

            List<Shape> shapes = new List<Shape>();

            int countOfShape = 5;

            for (int i = 0; i < countOfShape; i++)
            {
                Console.Write("Enter square name: ");
                string name = Console.ReadLine();
                Console.Write("Enter square side: ");
                double side = Convert.ToDouble(Console.ReadLine());

                Square square = new Square(string.Concat("Square ", name));
                square.Side = side;
                shapes.Add(square);
            }

            for (int i = 0; i < countOfShape; i++)
            {
                Console.Write("Enter circle name: ");
                string name = Console.ReadLine();
                Console.Write("Enter circle radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                Circle circle = new Circle(string.Concat("Circle ", name));
                circle.Radius = radius;
                shapes.Add(circle);
            }

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Name: {0} Perimeter: {1} Area: {2}", shape.Name, shape.Perimeter(), shape.Area());
                Console.WriteLine("-------------------");
            }

            //Task b

            var maxPer = shapes.Max(i => i.Perimeter());
            Shape shapeWithMaxPer = shapes.FirstOrDefault(i => i.Perimeter() == maxPer);

            Console.WriteLine("\nShape with larges perimeter - {0}\n", shapeWithMaxPer.Name);

            //Task 3

            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Name: {0} Perimeter: {1} Area: {2}", shape.Name, shape.Perimeter(), shape.Area());
                Console.WriteLine("-------------------");
            }

            Console.ReadLine();

        }
    }
}
