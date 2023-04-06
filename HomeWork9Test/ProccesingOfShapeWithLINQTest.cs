using FluentAssertions;
using HomeWork8;
using HomeWork9;

namespace HomeWork9Test
{
    [TestClass]
    public class ProccesingOfShapeWithLINQTest
    {
        string filePath = "shapesArea.txt";
        char a = 'a';

        [TestMethod]
        public void GetShapesListByRangeTest()
        {
            //arrange
            ListOfShape listOfShape = new ListOfShape();
            ProccesingOfShapeWithLINQ proccesingOfShapeWithLINQ = new ProccesingOfShapeWithLINQ(filePath, listOfShape.AddedSHapeToList());

            List<Shape> expectedList = new List<Shape>()
            {
                new Square("Square_2")
                {
                    Side = 2 * 3
                },
                new Circle("Circle_1")
                {
                    Radius = 1 * 3
                }
            };

            bool expected = true;

            //act
            List<Shape> result = proccesingOfShapeWithLINQ.GetShapesListByRange();

            //Assert
            Assert.AreEqual(expected, CompareList.CompareShapeList(expectedList, result));
        }

        [TestMethod]
        public void GetShapesListByContainsLetterTest()
        {
            //arrange
            ListOfShape listOfShape = new ListOfShape();
            ProccesingOfShapeWithLINQ proccesingOfShapeWithLINQ = new ProccesingOfShapeWithLINQ(filePath, listOfShape.AddedSHapeToList());
            List<Shape> expectedList = new List<Shape>()
            {
                new Square("Square_0")
                {
                    Side = 0 * 3
                },
                new Square("Square_1")
                {
                    Side = 1 * 3
                },
                new Square("Square_2")
                {
                    Side = 2 * 3
                },
            };
            bool expected = true;


            //act
            List<Shape> result = proccesingOfShapeWithLINQ.GetShapesListByContainsLetter(a);

            //Assert
            Assert.AreEqual(expected, CompareList.CompareShapeList(expectedList, result));
        }
    }
}