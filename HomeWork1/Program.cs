using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        private const double PI = 3.14159265359;
        static void Main(string[] args)
        {
            //Task 1
            int a;
            string buff;
            bool isValidA;

            Console.Write("Enter the side of the square: ");
            buff = Console.ReadLine();
            isValidA = Int32.TryParse(buff, out a);
            Console.WriteLine($"Area: {a * a}\nPerimeter: {a * 4}.");

            Console.WriteLine("\n----------------------------\n");

            //Task 2
            string name;
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name}. You are {age} year old.");

            Console.WriteLine("\n----------------------------\n");

            //Task 3
            double r;

            Console.Write("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double length = 2 * PI * r;
            double area = PI * Math.Pow(r, 2);
            double volume = 4d / 3d * PI * Math.Pow(r, 3);

            Console.WriteLine("Length: {0:0.00}, area: {1:0.00}, volume: {2:0.00}", length, area, volume);
            Console.ReadLine();
        }
    }
}
