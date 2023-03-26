using HomeWork8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class ProccesingOfShapeWithLINQ
    {
        string filePath;
        List<Shape> shapes;

        public ProccesingOfShapeWithLINQ(string filePath, List<Shape> shapes)
        {
            FilePath = filePath;
            Shapes = shapes;
        }

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public List<Shape> Shapes
        {
            get { return shapes; }
            set { shapes = value; }
        }
        public void WriteShapesThatsFindByAreaRange()
        {
            string title = "Shapes with area from range [10,100]";
            writeTextToFile(false, title, GetShapesListByRange());
        }

        public void WriteShapesThatsFindByAreaRange(char letter)
        {
            string title = "Shapes which name contains letter 'a'";
            writeTextToFile(true, title, GetShapesListByContainsLetter(letter));
        }

        private void writeTextToFile(bool newFileOrNo, string preface, List<Shape> shapesForSave)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath, newFileOrNo, Encoding.UTF8))
            {
                streamWriter.WriteLine(preface);

                foreach (Shape shape in shapesForSave)
                {
                    streamWriter.WriteLine(shape.Name);
                }
            }
        }

        private List<Shape> GetShapesListByRange()
        {
            return shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100).ToList();
        }

        private List<Shape> GetShapesListByContainsLetter(char letter)
        {
            return shapes.Where(shape => shape.Name.Contains(letter)).ToList();
        }

        public void RemoveShapeByPerimeterThatLessThan(int numForRemove)
        {
            shapes.RemoveAll(shape => shape.Perimeter() < numForRemove);
        }

        public void ShowShapes()
        {
            foreach (Shape shape in shapes)
                Console.WriteLine(shape.Perimeter());
        }
    }
}
