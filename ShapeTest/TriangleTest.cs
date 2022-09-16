using ShapeLib.Shapes;
using ShapeLib.Simple;

namespace ShapeTest
{
    [TestClass]
    public class TriangleTest
    {
        
        [TestMethod]
        public void Triangle_CalculateArea()
        {
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5)});
            decimal expected = 6;
            // Act & assert  
            Assert.AreEqual(expected, triangle.CalculateArea());
        }
        [TestMethod]
        public void Triangle_CalculateArea_FromCtor()
        {
            // Arrange & act
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5) });
            decimal expected = 6;
            // Assert
            Assert.AreEqual(expected, triangle.Area);
        }
        [TestMethod]
        public void Triangle_CalculateArea_SetValue()
        {
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5) });
            var expected = 5.00009110686042m;
            // Act
            triangle.Sides[2].Size = 3.4255m;
            // Assert
            Assert.AreEqual(expected, triangle.Area);
        }
        [TestMethod]
        public void Triangle_CanExist_Exception()
        {
            // Arrange & act & assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(new Side[] { new Side(3), new Side(4), new Side(1) }));
        }
        [TestMethod]
        public void Triangle_CanExist_Exception_SetValue()
        {
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5) });
            // Act & assert
            Assert.ThrowsException<ArgumentException>(() => triangle.Sides[2].Size = 1);
        }
        [TestMethod]
        public void Triangle_CanExist_Success()
        {
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5) });
            var expected = true;
            // Act & assert
            Assert.AreEqual(expected, triangle.CanExist());
        }
        [TestMethod]
        public void Triangle_IsRight_True()
        {
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5) });
            var expected = true;
            // Act & assert
            Assert.AreEqual(expected, triangle.IsRight());
        }
        [TestMethod]
        public void Triangle_IsRight_False()
        {
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(4) });
            var expected = false;
            // Act & assert
            Assert.AreEqual(expected, triangle.IsRight());
        }
        [TestMethod]
        public void Triangle_HasThreeSides()
        {
            // :)
            // Arrange
            var triangle = new Triangle(new Side[] { new Side(3), new Side(4), new Side(4) });
            var expected = 3;
            // Act & assert;
            Assert.AreEqual(expected, triangle.CountSides);
        }
    }
}