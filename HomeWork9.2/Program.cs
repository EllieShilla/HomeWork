using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "shapesArea.txt";
            WorkWithString workWithString = new WorkWithString(filePath);
            workWithString.ReadFile();

            //Task 1

            workWithString.ShowLenthLines();

            //Task 2

            workWithString.ShowLongestAndShortestLines();

            //Task 3

            workWithString.RegexLinesWithVar();

            Console.ReadLine();

        }
    }
}
