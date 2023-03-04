using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class AverageNum
    {
        int num = 0;
        int sum = 0;
        int count = 0;

        public void EnterNumber()
        {
            Console.WriteLine("Enter numbers: ");

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                count++;

            } while (num >= 0);
        }

        public int CountingAvg()
        {
            count--;
            sum += Math.Abs(num);
            int avg = sum / count;
            return avg;
        }
    }
}
