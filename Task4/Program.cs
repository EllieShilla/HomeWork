using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2

            Car car1 = new Car("car1", "black", 750000.00);
            Car car2 = new Car("car2", "red", 600000.00);
            Car car3 = new Car("car1", "white", 750000.00);

            //Task 3

            car1.ChangePrice(10);
            car2.ChangePrice(10);
            car3.ChangePrice(10);

            car1.Print();
            car2.Print();
            car3.Print();

            //Task 4

            Console.Write("Enter color: ");
            car3.Color = Console.ReadLine();

            //Task 5

            if (car1 == car2) Console.WriteLine("1 and 2 same");
            else Console.WriteLine("1 and 2 not same");

            if (car1 == car3) Console.WriteLine("1 and 3 same");
            else Console.WriteLine("1 and 3 not same");

            Console.ReadLine();
        }
    }
}
