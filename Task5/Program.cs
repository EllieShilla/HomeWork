using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyables = new List<IFlyable>() {
                                                             new Bird("sparrow", true),
                                                             new Bird("penguin", false),
                                                             new Plane("Boeing 747",15000)
                                                           };

            foreach (IFlyable flyable in flyables)
                flyable.Fly();

            Numbers numbers = new Numbers();
            numbers.SetNumberList();
            Console.WriteLine("\nIndexes -10 elements: ");
            numbers.FindAllIndex();
            numbers.RemoveElementsWhichGraterThanSpecNum();
            Console.WriteLine("\nRemove item over 20: ");
            numbers.ShowList();
            numbers.InsertElem();
            Console.WriteLine("\nInsert elements: ");
            numbers.ShowList();
            numbers.SortList();
            Console.WriteLine("\nSort: ");
            numbers.ShowList();

            Console.ReadLine();
        }
    }
}
