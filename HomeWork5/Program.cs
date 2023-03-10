using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1-3

            DeveloperShow developerShow = new DeveloperShow();
            developerShow.CreateProgrammerAndBuilder();
            developerShow.AddToIDeveloperList();
            developerShow.ShowCreateAndDestroy();

            //Task 4

            developerShow.SortDevelopers();
            developerShow.ShowDevelopers();

            //Task 2

            Console.Write("Enter 7 names, separated by a space: ");
            string namesStr = Console.ReadLine();
            var nameArr = namesStr.Split(' ');

            //Task 1

            Dictionary<uint, string> names = new Dictionary<uint, string>();

            names.Add(1, nameArr[0]);
            names.Add(2, nameArr[1]);
            names.Add(3, nameArr[2]);
            names.Add(4, nameArr[3]);
            names.Add(5, nameArr[4]);
            names.Add(6, nameArr[5]);
            names.Add(7, nameArr[6]);

            //Task 3

            Console.Write("Enter name id: ");
            uint id = Convert.ToUInt32(Console.ReadLine());

            string name;
            bool hasValue = names.TryGetValue(id, out name);

            if (hasValue)
                Console.WriteLine(name);
            else
                Console.WriteLine("Can't find name by id");

            Console.ReadLine();
        }
    }
}
