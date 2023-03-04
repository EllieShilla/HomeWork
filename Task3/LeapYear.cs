using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal static class LeapYear
    {
        public static bool IdentifyLeapYear(int year)
        {
            bool isLeap = false;

            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                        isLeap = true;
                }
                else
                    isLeap = true;
            }
            return isLeap;
        }
    }
}
