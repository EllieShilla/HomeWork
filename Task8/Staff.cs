using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public override string Name
        {
            get { return base.Name; }
        }

        public int CompareTo(Staff other)
        {
            return salary.CompareTo(other.salary);
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, this.salary);
        }
    }
}
