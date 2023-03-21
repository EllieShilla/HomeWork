using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3

            List<Person> persons = new List<Person>()
            {
                   new Person("Johny"),
                   new Staff("Ira", 300),
                   new Teacher ("Yaru", 500, ".Net"),
                   new Developer("Nata",400, "Junior")
            };

            foreach (var person in persons)
                person.Print();

            //Task 4

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            var personByName = persons.FirstOrDefault(p => p.Name.ToLower().Equals(name.ToLower()));

            if (personByName != null)
                personByName.Print();
            else
                Console.WriteLine("Person with this name not found.");

            //Task 5

            persons.Sort();

            foreach (var person in persons)
                person.Print();

            //Task 6

            List<Staff> employees = new List<Staff>();

            foreach (var person in persons)
            {
                if (person is Teacher || person is Developer)
                    employees.Add(person as Staff);
            }

            employees.Sort();

            Console.ReadLine();
        }
    }
}
