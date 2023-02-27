using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class IntegerAB
    {
        int a = 0;
        int b = 0;
        string buff;
        bool isValidA;
        bool isValidB;

        public int[] ReadIntegerAB()
        {
            do
            {
                Console.Write("Enter a: ");
                buff = Console.ReadLine();
                isValidA = Int32.TryParse(buff, out a);
                Console.Write("Enter b: ");
                buff = Console.ReadLine();
                isValidB = Int32.TryParse(buff, out b);

                if (!isValidA || !isValidB)
                {
                    Console.WriteLine("a and b must be integers");
                }
            } while (!isValidA || !isValidB);

            Console.Clear();

            return new int[] { a, b };
        }
    }
}
