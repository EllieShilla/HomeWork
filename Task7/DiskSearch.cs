using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class DiskSearch
    {
        string dirName = "D:\\";
        string filePath = "DirectoryC.txt";
        string[] dirs;
        FileInfo[] fileInfo;

        public void GetDataFromDirectory()
        {
            if (Directory.Exists(dirName))
            {
                dirs = Directory.GetDirectories(dirName);
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                fileInfo = dirInfo.GetFiles();
                setDataToFile();
            }
            else
                throw new Exception($"Directory {dirName} not exist.");
        }

        private void setDataToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                DirectoryInfo directoryInfo;

                sw.WriteLine("Directories:\n");

                foreach (string dir in dirs)
                {
                    directoryInfo = new DirectoryInfo(dir);
                    sw.WriteLine($"Name: {directoryInfo.Name} | " +
                        $"Creation Time:{directoryInfo.CreationTime}");
                }

                sw.WriteLine("\nFiles:\n");

                foreach (FileInfo file in fileInfo)
                {
                    sw.WriteLine($"Name: {file.Name} | " +
                        $"Extension: {file.Extension} |" +
                        $"Creation Time:{file.CreationTime}");
                }
            }
        }
    }
}
