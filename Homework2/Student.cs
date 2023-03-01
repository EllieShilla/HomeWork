using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal struct Student
    {
        private string lastName;
        private int groupNumber;

        public Student(string lastName, int groupNumber)
        {
            this.lastName = lastName;
            this.groupNumber = groupNumber;
        }

        public string LastName { get { return lastName; } }
        public int GroupNumber { get { return groupNumber; } }
    }
}
