using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int a;
            int b;
            int countWithoutRemainder = 0; ;
            int divider = 3;

            do
            {
                Console.Write("Enter int a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter int b: ");
                b = Convert.ToInt32(Console.ReadLine());

            } while (a >= b);

            for (int i = a; i < b; i++)
            {
                if (i % divider == 0)
                    countWithoutRemainder++;
            }

            Console.WriteLine("{0} count without remainder", countWithoutRemainder);

            //Task 2
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.ToArray().Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(text[i]);
            }

            //Task3
            Drinks drinks = new Drinks();

            Console.Write("Enter drink name: ");
            string drinkName = Console.ReadLine();

            Drink drink = drinks.SearchDrink(drinkName);

            if (drink != null)
                Console.WriteLine(drink.PrintTitleAndPrice());
            else
                Console.WriteLine("There is no such drink");

            //Task 4

            AverageNum averageNum = new AverageNum();
            averageNum.EnterNumber();

            Console.WriteLine(averageNum.CountingAvg());

            //Task 5
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (LeapYear.IdentifyLeapYear(year))
                Console.WriteLine("Year is a leap");
            else
                Console.WriteLine("Year is not a leap");

            //Task 6

            Console.Write("Enter integer: ");
            string strNum = Console.ReadLine();
            int sum = 0;
            foreach (char i in strNum)
            {
                sum += Convert.ToInt32(i.ToString());
            }
            Console.WriteLine("Sum of {0} = {1}", strNum, sum);

            //Task 7

            Console.Write("Enter integer: ");
            string strInteger = Console.ReadLine();

            EvenOdd evenOdd = new EvenOdd(strInteger);

            if (evenOdd.OddOrEven())
                Console.WriteLine("Entered integer number contains only odd digits");
            else
                Console.WriteLine("Entered integer number contains even and odd digits");


            Console.ReadLine();
        }
    }
}
