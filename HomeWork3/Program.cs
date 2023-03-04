using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int count = 0;

            Console.Write("Enter something: ");
            string str = Console.ReadLine();

            foreach (char i in str)
            {
                if (i.ToString().ToLower().Equals("a") ||
                    i.ToString().ToLower().Equals("o") ||
                    i.ToString().ToLower().Equals("i") ||
                    i.ToString().ToLower().Equals("e"))
                {
                    count++;
                }
            }

            Console.WriteLine("The count of letters 'a', 'o', 'i', 'e' in string {0} is equal to {1}", str, count);

            //Task 2

            Console.Write("Enter number of month: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            CultureInfo ci = new CultureInfo("en-US");
            string monthName = ci.DateTimeFormat.GetMonthName(monthNum);

            int days = DateTime.DaysInMonth(DateTime.Now.Year, monthNum);

            Console.WriteLine("Count of days in {0}: {1}", monthName, days);

            //Task 3

            int[] intArr = new int[10];

            Console.WriteLine("Enter 10 integer numbers, separated by a space: ");

            string buff = Console.ReadLine();

            var stringArr = buff.Split(' ');
            if (stringArr.Length == 10)
                intArr = Array.ConvertAll(stringArr, int.Parse);

            var moreThenZero = intArr.Where(i => i > 0).Count();

            if (moreThenZero == intArr.Length)
            {
                Console.WriteLine("Sum of first 5 element = {0}", MathOperation.Sum(intArr));
            }
            else
            {
                Console.WriteLine("Product of last 5 element = {0}", MathOperation.Multiply(intArr));
            }

            Console.ReadLine();
        }
    }
}
