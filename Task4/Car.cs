using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Car
    {
        string name;
        string color;
        double price;
        const string CompanyName = "BMW";

        public Car() { }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void Input()
        {
            Console.Write("Enter car name: ");
            name = Console.ReadLine();
            Console.Write("Enter color car: ");
            color = Console.ReadLine();
            Console.Write("Enter price car: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Car name: {name}, color: {color}, price: {price}, company name: {CompanyName}");
        }

        public void ChangePrice(double x)
        {
            double procentNum = (x * price) / 100;
            price -= procentNum;
        }

        public override string ToString()
        {
            return $"Car name: {name}, color: {color}, price: {price}, company name: {CompanyName}";
        }

        public static bool operator ==(Car car1, Car car2)
        {
            return (car1.name == car2.name) && (car1.price == car2.price);
        }

        public static bool operator !=(Car car1, Car car2)
        {
            return !((car1.name == car2.name) && (car1.price == car2.price));
        }

    }
}
