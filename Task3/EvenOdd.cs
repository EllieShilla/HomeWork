using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class EvenOdd
    {
        bool isOdd = true;
        string strNum;

        public EvenOdd(string strNum)
        {
            this.strNum = strNum;
        }

        public bool OddOrEven()
        {
            foreach (char i in strNum)
            {
                if ((Convert.ToInt32(i.ToString()) % 2) != 0)
                    isOdd = false;
            }
            return isOdd;
        }
    }
}
