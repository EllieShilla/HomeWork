using HomeWork10;

namespace HomeWork10Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void PerimeterTest()
        {
            //arrange
            Triangle triangleTest = new Triangle(new Point(1, 2), new Point(3, -4), new Point(-4, 5));
            double expected = 23.557261466173436;

            //act
            double result = triangleTest.Perimeter();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square()
        {
            //arrange
            Triangle triangleTest = new Triangle(new Point(1, 2), new Point(3, -4), new Point(-4, 5));
            double expected = 11.999999999999986;

            //act
            double result = triangleTest.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}