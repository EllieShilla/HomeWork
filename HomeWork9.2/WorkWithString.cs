using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork9._2
{
    internal class WorkWithString
    {
        string[] strArray;
        string path = "";

        public WorkWithString(string path)
        {
            Path = path;
        }

        public string[] StrArray
        {
            get { return strArray; }
            set { strArray = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public void ReadFile()
        {
            strArray = File.ReadAllLines(path);
        }
        public void ShowLenthLines()
        {
            Console.WriteLine("Number of symbols in every line: ");
            foreach (string str in strArray)
            {
                Console.WriteLine(string.Concat(str, " - ", str.Length));
            }
        }

        private string getLongestLine()
        {
            return strArray.Aggregate((maxLenth, curLenth) => maxLenth.Length > curLenth.Length ? maxLenth : curLenth);
        }

        private string getShortestLine()
        {
            return strArray.Aggregate((maxLenth, curLenth) => maxLenth.Length < curLenth.Length ? maxLenth : curLenth);
        }

        public void ShowLongestAndShortestLines()
        {
            Console.WriteLine($"\nLongest line: {getLongestLine()}\nShortest line: {getShortestLine()}\n");
        }

        public void RegexLinesWithVar()
        {
            string pattern = @"^\s?(var)\s?\1?$";
            Regex regex = new Regex(pattern);

            var strVarArr = strArray.AsEnumerable().Where(line => regex.IsMatch(line)).ToArray();

            Console.WriteLine("Lines, which consist of word \"var\":");

            foreach (string line in strVarArr)
            {
                Console.WriteLine(line);
            }
        }
    }
}
