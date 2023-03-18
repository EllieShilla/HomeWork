using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            ReadFromFile readFromFile = new ReadFromFile();
            WriteToFile writeToFile = new WriteToFile();

            try
            {
                if (writeToFile.SetDataToFile(readFromFile.GetDataFromFile()))
                {
                    Console.WriteLine("Reading and writing all data from data.txt file to rez.txt files successfully completed.\n");
                }
                else
                {
                    Console.WriteLine("Reading and writing all data from data.txt file to rez.txt files has failed.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                //Task 2
                DiskSearch diskSearch = new DiskSearch();
                diskSearch.GetDataFromDirectory();

                //Task 3
                DIrectorySearch dIrectorySearch = new DIrectorySearch();
                dIrectorySearch.GetTxtFilesFromDirectory();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
