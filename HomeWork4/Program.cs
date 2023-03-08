using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            List<Person> persons = new List<Person>() { new Person("person1", new DateTime(2016, 2, 29)),
                                                        new Person("person2", new DateTime(1970, 6, 14)),
                                                        new Person("person6", new DateTime(1991, 12, 20)),
                                                        new Person("person4", new DateTime(2002, 7, 27)),
                                                        new Person("person5", new DateTime(1993, 1, 4)),
                                                        new Person("person6", new DateTime(1984, 4, 15))
                                                      };

            //Task 2

            persons.ForEach(person => person.Output());

            //Task 3

            persons.Where(person => person.Age() < 16).ToList().ForEach(i => i.ChangeName("Very Young"));

            //Task 4

            persons.ForEach(person => person.Output());

            //Task 4

            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count; j++)
                {
                    if (i != j)
                    {
                        if (persons[i] == persons[j])
                        {
                            Console.WriteLine($"{persons[j]}");
                        }
                    }

                }
            }

            Console.ReadLine();
        }
    }
}
