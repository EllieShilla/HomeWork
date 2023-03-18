using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class ReadFromFile
    {
        string readFromFilePath = "data.txt";
        public string GetDataFromFile()
        {
            if (File.Exists(readFromFilePath))
            {
                StreamReader reader = new StreamReader(readFromFilePath);
                string data = reader.ReadToEnd();
                reader.Close();
                return data;
            }
            else
                throw new Exception($"File {readFromFilePath} not exist.");

        }
    }
}
