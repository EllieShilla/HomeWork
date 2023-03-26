using HomeWork8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListOfShape listOfShape = new ListOfShape();
            string filePath = "shapesArea.txt";
            char a = 'a';
            int perimeterResultFOrRemove = 5;

            //Task 1

            ProccesingOfShapeWithLINQ proccesingOfShapeWithLINQ = new ProccesingOfShapeWithLINQ(filePath, listOfShape.AddedSHapeToList());

            //Task 2

            proccesingOfShapeWithLINQ.WriteShapesThatsFindByAreaRange();

            //Task 3

            proccesingOfShapeWithLINQ.WriteShapesThatsFindByAreaRange(a);

            //Task 4

            proccesingOfShapeWithLINQ.RemoveShapeByPerimeterThatLessThan(perimeterResultFOrRemove);

            Console.WriteLine("Shapes with perimeter more and equal 5:");
            proccesingOfShapeWithLINQ.ShowShapes();

            Console.ReadLine();
        }
    }
}
