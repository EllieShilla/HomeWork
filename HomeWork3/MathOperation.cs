using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public static class MathOperation
    {
        public static int Sum(int[] numArr)
        {
            return numArr.Take(5).Sum();
        }

        public static int Multirlu(int[] numArr)
        {
            int[] lastFiveNum = numArr.Reverse().Take(5).ToArray();

            var multiply = 1;

            foreach (var i in lastFiveNum)
                multiply *= i;

            return multiply;
        }
    }
}
