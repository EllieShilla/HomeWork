using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Accountancy
    {
        public void PayingFellowship(int estimate)
        {
            if (estimate > 10)
            {
                Console.WriteLine("Student will have a scholarship.");
            }
            else
            {
                Console.WriteLine("Student won't have a scholarship.");
            }
        }
    }
}
