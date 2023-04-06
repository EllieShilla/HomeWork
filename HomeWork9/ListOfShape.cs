using HomeWork8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class ListOfShape
    {
        List<Shape> shapes;
        int countOfShape = 3;

        public ListOfShape()
        {
            shapes = new List<Shape>();
        }

        public List<Shape> AddedSHapeToList()
        {
            for (int i = 0; i < countOfShape; i++)
            {
                Square square = new Square(string.Concat("Square_", i));
                square.Side = i * 3;
                shapes.Add(square);
            }

            for (int i = 0; i < countOfShape; i++)
            {
                Circle circle = new Circle(string.Concat("Circle_", i));
                circle.Radius = i * 3;
                shapes.Add(circle);
            }

            return shapes;
        }
    }
}
