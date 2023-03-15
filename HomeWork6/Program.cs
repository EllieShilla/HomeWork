using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            double num1 = 0;
            double num2 = 0;
            try
            {
                Console.Write("Enter num1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter num2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                //Task 2
                if ((int)num1 != num1 && (int)num2 != num2)
                    throw new Exception("Exception: Dividing of two double numbers.");


                Div(Convert.ToInt32(num1), Convert.ToInt32(num2));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Task 3
            int maxIndex = 10;

            try
            {
                Console.Write("Enter the beginning of range: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the end of range: ");
                int end = Convert.ToInt32(Console.ReadLine());

                if (start > end)
                    throw new Exception("Beginning of range more than end.");

                if (start == end)
                    throw new Exception("Beginning of range equals to end.");

                if (start + 8 >= end)
                    throw new Exception("There is no way to make a range of 10 numbers.");

                int minNum = ReadNumber(start, end);

                for (int i = 2; i < maxIndex; i++)
                {
                    Console.Write("Enter next range number: ");
                    int nextNum = Convert.ToInt32(Console.ReadLine());
                    if (nextNum > minNum && nextNum < end)
                        minNum = ReadNumber(nextNum, end);
                    else
                        throw new Exception("Number is not in range");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }

        static void Div(int num1, int num2)
        {
            int result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"{num1}/{num2} = {result}");
        }

        static int ReadNumber(int start, int end)
        {
            return start;
        }
    }
}
