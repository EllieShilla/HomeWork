using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Task
            IntegerAB integerAB = new IntegerAB();

            var integerArr = integerAB.ReadIntegerAB();
            int a = integerArr[0];
            int b = integerArr[1];

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");

            if (b != 0)
                Console.WriteLine($"{a} / {b} = {(double)a / b}");
            else
                Console.WriteLine("You cannot divide by zero");

            //Second Task
            Console.WriteLine("\nHow are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");

            //Third Task
            Console.Write("\nEnter first char: ");
            char firstChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second char: ");
            char secondChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter third char: ");
            char thirdChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"You enter {firstChar}, {secondChar}, {thirdChar}.\n");

            //Fourth Task
            integerArr = integerAB.ReadIntegerAB();
            a = integerArr[0];
            b = integerArr[1];

            if (a < 0 || b < 0)
            {
                Console.WriteLine("Not all numbers entered are positive");
            }
            else
            {
                Console.WriteLine($"{a} and {b} positive");
            }

            Console.ReadLine();
        }
    }
}
