using System;

namespace HomeWork10
{
    public class Triangle
    {
        Point vertex1;
        Point vertex2;
        Point vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        private int getPointElement(Point point, int index)
        {
            string trim = point.ToString().Trim('(', ')');
            return Convert.ToInt32(trim.ToString().Split(',')[index]);
        }

        private double distance(Point point1, Point point2)
        {
            double point = Math.Sqrt(Math.Pow((getPointElement(point2, 0) - getPointElement(point1, 0)), 2) +
                             Math.Pow((getPointElement(point2, 1) - getPointElement(point1, 1)), 2));
            return point;
        }

        public double Perimeter()
        {
            return distance(vertex1, vertex2) + distance(vertex3, vertex2) + distance(vertex1, vertex3);
        }

        public double Square()
        {
            double p = (distance(vertex1, vertex2) + distance(vertex3, vertex2) + distance(vertex1, vertex3)) / 2;
            double square = Math.Sqrt(p * (p - distance(vertex1, vertex2)) * (p - distance(vertex3, vertex2)) * (p - distance(vertex1, vertex3)));
            return square;
        }

        public void Print(string text, double data)
        {
            Console.WriteLine(text + $" with points {vertex1.ToString()}, {vertex2.ToString()}, {vertex3.ToString()}: " + (Math.Truncate(data * 10) / 10).ToString("F1"));
        }

    }
}
