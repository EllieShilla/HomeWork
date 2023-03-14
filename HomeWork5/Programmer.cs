using System;
using System.Xml.Linq;

namespace HomeWork5
{
    public class Programmer : IDeveloper
    {
        string language;

        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }

        public void Create()
        {
            Console.WriteLine("Create Programmer class " + language);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy Programmer class " + language);
        }
    }
}
