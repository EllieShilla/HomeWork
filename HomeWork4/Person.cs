using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Person
    {
        string name;
        DateTime birthYear;

        public Person()
        {
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }
        public void Input()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your birthday: ");
            birthYear = Convert.ToDateTime(Console.ReadLine());
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return $"Name: {name}, age: {Age()}";
        }
        public void Output()
        {
            Console.WriteLine(ToString() + "\n");
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Name == person2.Name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1.Name == person2.Name);
        }



    }
}
