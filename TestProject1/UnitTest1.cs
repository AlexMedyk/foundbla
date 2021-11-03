using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp5;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsValid_TriangleSides_ReturnsFalse()
        {
            bool IsValid = Triangle.IsValid(41, 3, 2);
            Assert.IsFalse(IsValid);
        }
        [TestMethod]
        public void IsValid_TriangleSides_ReturnsTrue()
        {
            bool IsValid = Triangle.IsValid(4, 3, 2);
            Assert.IsTrue(IsValid);
        }
        [TestMethod]
        public void CheckEqual_TriangleSides_ReturnsTrue()
        {
            bool IsEqual = Triangle.CheckEqual(1.000001, 1.0000005);
            Assert.IsTrue(IsEqual);
        }
        [TestMethod]
        public void CheckEqual_TriangleSides_ReturnsFalse()
        {
            bool IsEqual = Triangle.CheckEqual(1.000001, 1.1);
            Assert.IsFalse(IsEqual);
        }
        [TestMethod]
        public void Perimeter_TriangleSides_ReturnsSumOfSides()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double res = triangle.Perimeter;
            Assert.AreEqual(12, res);
        }
        [TestMethod]
        public void Area_Triangle_ReturnsRightValue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double res = triangle.Area;
            Assert.AreEqual(6, res);
        }
        [TestMethod]
        public void IsRightAngled_Triangle_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool IsRightAngled = triangle.IsRightAngled;
            Assert.IsTrue(IsRightAngled);
        }
        [TestMethod]
        public void IsEquilateral_Triangle_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 3, 3);
            bool IsEquilateral = triangle.IsEquilateral;
            Assert.IsTrue(IsEquilateral);
        }
        [TestMethod]
        public void AreCongruents_Triangle_ReturnsTrue()
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(5, 4, 3);
            bool AreCongruents = triangle1.AreCongruents(triangle2);
            Assert.IsTrue(AreCongruents);
        }
    }
}