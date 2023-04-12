using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Program
    {
        public delegate void MyDel(int m);
        static void Main(string[] args)
        {
            Parent parent = new Parent();

            Student student = new Student();
            student.Name = "Student One";
            student.MarkChange += parent.OnMarkChange;

            Accountancy accountancy = new Accountancy();
            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(3);
            student.AddMark(12);
            student.AddMark(1);

            Console.ReadLine();
        }
    }
}
