using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class DIrectorySearch
    {
        string dirName = "D:\\";

        public void GetTxtFilesFromDirectory()
        {
            if (Directory.Exists(dirName))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                List<FileInfo> files = dirInfo.GetFiles().Where(file => file.Extension.Equals(".txt")).ToList();
                showTextFromFile(files);
            }
            else
                throw new Exception($"Directory {dirName} not exist.");
        }

        private void showTextFromFile(List<FileInfo> files)
        {
            StreamReader streamReader;
            foreach (FileInfo file in files)
            {
                streamReader = new StreamReader(file.FullName);
                Console.WriteLine(streamReader.ReadToEnd());
            }
        }
    }
}
