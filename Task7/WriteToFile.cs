using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class WriteToFile
    {
        string riteDataToTextPath = "rez.txt";
        public bool SetDataToFile(string content)
        {
            if (content != null)
            {
                File.WriteAllText(riteDataToTextPath, content);
                return true;
            }
            return false;
        }
    }
}
