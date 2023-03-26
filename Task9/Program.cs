using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int[] intArr = new int[] { 1, 2, -3, 8, 5, 4, 36, -12, 22, 1 };

            //Task 2

            var negativeNumbers = intArr.Where(i => i < 0).ToList();

            Console.Write("Negative numbers: ");
            foreach (int i in negativeNumbers)
                Console.Write(i + " ");

            //Task 3

            var positiveNumbers = intArr.Where(i => i > 0).ToList();

            Console.Write("\nPositive numbers: ");
            foreach (int i in positiveNumbers)
                Console.Write(i + " ");

            //Task 4

            var largeElem = intArr.Max(i => i);
            var smallElem = intArr.Min(i => i);
            var sum = intArr.Sum(i => i);
            Console.Write($"\nMax: {largeElem}\nMin: {smallElem}\nSum: {sum}");

            //Task 5

            intArr = intArr.OrderByDescending(i => i).ToArray();
            var smallerThanEverage = intArr.FirstOrDefault(i => i < (sum / intArr.Length));
            Console.Write("\nFirst largest element in array that is smaller than the Average ({1}) of elements in array: {0}", smallerThanEverage, sum / intArr.Length);

            //Task 6

            intArr = intArr.OrderBy(i => i).ToArray();

            Console.Write("\nOrder by: ");
            foreach (int i in intArr)
                Console.Write(i + " ");

            Console.ReadLine();
        }
    }
}
