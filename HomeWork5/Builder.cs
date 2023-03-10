using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Builder : IDeveloper
    {
        string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }

        public void Create()
        {
            Console.WriteLine("Create Builder class");
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy Builder class");
        }
    }
}
