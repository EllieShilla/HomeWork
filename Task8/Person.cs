using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    [Serializable]
    public class Person : IComparable<Person>
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public Person() { }

        public virtual string Name { get { return name; } }

        public int CompareTo(Person other)
        {
            return string.Compare(Name, other.Name);
        }

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
}
