using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Dog
    {
        private string name;
        private string mark;
        private int age;

        public Dog(string name, string mark, int age)
        {
            this.name = name;
            this.mark = mark;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name - {name}, Mark - {mark}, Age - {age}";
        }
    }
}
