using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework2
{
    internal class Program
    {
        enum HTTPError
        {
            [EnumMember(Value = "Bad Request")] BadRequest = 400,
            [EnumMember(Value = "Unauthorized")] Unauthorized = 401,
            [EnumMember(Value = "Payment Required")] PaymentRequired = 402
        };

        static void Main(string[] args)
        {
            //Task 1
            string buff;
            bool isParse;
            float firstF;
            float secondF = 0;
            float thirdF = 0;

            Console.Write("Enter first float: ");
            buff = Console.ReadLine();
            isParse = float.TryParse(buff, out firstF);

            Console.Write("Enter second float: ");
            buff = Console.ReadLine();
            isParse = float.TryParse(buff, out secondF);

            Console.Write("Enter third float: ");
            buff = Console.ReadLine();
            isParse = float.TryParse(buff, out thirdF);

            Console.WriteLine(((firstF >= -5 && firstF <= 5) &&
                              (secondF >= -5 && secondF <= 5) &&
                              (thirdF >= -5 && thirdF <= 5)) ?
                              "All numbers in range[-5,5]" : "Not all numbers in range[-5,5]");

            Console.WriteLine("---------------------------");

            //Task 2
            Console.Write("Enter first int: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second int: ");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third int: ");
            int thirdInt = Convert.ToInt32(Console.ReadLine());

            int maxNun = firstInt > secondInt ? firstInt : secondInt;
            maxNun = thirdInt > maxNun ? thirdInt : maxNun;

            Console.WriteLine("Max is {0}", maxNun);

            Console.WriteLine("---------------------------");

            //Task 3
            EnumMemberAttr enumMember = new EnumMemberAttr();

            Console.Write("Enter number of HTTP error: ");
            int errorNum = Convert.ToInt32(Console.ReadLine());
            HTTPError error = (HTTPError)errorNum;
            Console.WriteLine(enumMember.GetEnumMemberAttrValue(error));

            Console.WriteLine("---------------------------");

            //Task 4
            Dog dog = new Dog("Bobik", "Mongrel", 5);
            Console.WriteLine(dog);

            Console.WriteLine("---------------------------");

            //Additional task 2
            Student[] students = new Student[] { new Student("Student1", 1),
                                                 new Student("Student2", 1),
                                                 new Student("Student3", 2),
                                                 new Student("Student4", 3),
                                                 new Student("Student5", 2) };

            Console.Write("Choose group number(1,2,3): ");
            int groupNum = Convert.ToInt32(Console.ReadLine());

            students.Where(i => i.GroupNumber == groupNum).ToList().ForEach(i => Console.WriteLine(i.LastName));

            Console.WriteLine("---------------------------");

            //Additional task 1
            Cat cat = new Cat();
            cat.EatSomething(Food.Mouse);
            cat.EatSomething(Food.Milk);
            cat.EatSomething(Food.Meat);

            Console.ReadLine();
        }
    }
}
