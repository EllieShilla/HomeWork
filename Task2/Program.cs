using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };
        enum RGB { red, green, blue };

        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter a day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((day > 0) && (day < 32) ? $"{day} can be day" : $"{day} can not be day");
            Console.WriteLine((month > 0) && (month < 13) ? $"{month} can be month" : $"{month} can not be month");

            Console.WriteLine("--------------------------");

            //Task 2
            Console.Write("Enter double: ");
            double firstDouble = Convert.ToDouble(Console.ReadLine());

            int digit1 = (int)(firstDouble * 10) % 10;
            int digit2 = (int)(firstDouble * 100) % 10;

            Console.WriteLine($"Sum of digits: {digit1 + digit2}");

            Console.WriteLine("--------------------------");

            //Task 3
            Console.Write("Enter hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if ((hour >= 5) && (hour < 12))
            {
                Console.WriteLine("Good morning!");
            }
            else if ((hour >= 12) && (hour < 18))
            {
                Console.WriteLine("Good afternoon!");
            }
            else if ((hour >= 12) && (hour < 22))
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }

            Console.WriteLine("--------------------------");

            //Task 4
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine("Test result: {0}", test1Status);


            Console.ReadLine();

        }
    }
}
