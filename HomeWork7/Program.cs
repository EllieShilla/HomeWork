using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneBookFilePath = "phones.txt";
            string phoneFilePath = "Phones(2).txt";
            string newPhoneFilePath = "New.txt";
            int lineCount = 9;

            if (File.Exists(phoneBookFilePath))
            {
                //Task 1
                Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

                using (StreamReader streamReader = new StreamReader(phoneBookFilePath, Encoding.UTF8))
                {
                    for (int i = 0; i < lineCount; i++)
                    {
                        string line = streamReader.ReadLine();
                        PhoneBook.Add(line.Split('|')[0], line.Split('|')[1]);
                    }
                }

                using (StreamWriter streamWriter = new StreamWriter(phoneFilePath, false, Encoding.UTF8))
                {
                    foreach (string phone in PhoneBook.Values)
                    {
                        streamWriter.WriteLine(phone);
                    }
                }

                //Task 2
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                string findPhone = PhoneBook.FirstOrDefault(i => i.Key.Equals(name)).Value;
                if (findPhone != null)
                    Console.WriteLine(findPhone);
                else
                    Console.WriteLine("Name not Found");

                //Task 3
                PhoneBook.Clear();

                using (StreamReader streamReader = new StreamReader(phoneBookFilePath, Encoding.UTF8))
                {
                    string line;

                    while (!string.IsNullOrEmpty(line = streamReader.ReadLine()))
                    {
                        PhoneBook.Add(line.Split('|')[0], line.Split('|')[1]);
                    }
                }

                var newPhoneBook = PhoneBook.Where(i => i.Value.StartsWith("8")).ToDictionary(i => i.Key, j => string.Concat("+3", j.Value));

                using (StreamWriter streamWriter = new StreamWriter(newPhoneFilePath, false, Encoding.UTF8))
                {
                    foreach (var item in newPhoneBook)
                    {
                        streamWriter.WriteLine(item.Key + "|" + item.Value);
                    }
                }
            }
            else
                Console.WriteLine($"File {phoneBookFilePath} does not exist");


            Console.ReadLine();
        }
    }
}
