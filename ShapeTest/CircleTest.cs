using ShapeLib.Shapes;
using ShapeLib.Simple;

namespace ShapeTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle_CalculateArea()
        {
            // Arrange
            var circle = new Circle(10);
            var expected = (decimal)Math.PI * 100;
            // Act & assert 
            Assert.AreEqual(expected, circle.CalculateArea());
        }
        [TestMethod]
        public void Circle_CalculateArea_FromCtor()
        {
            // Arrange & act
            var circle = new Circle(5);
            var expected = (decimal)Math.PI * 25;
            // Assert
            Assert.AreEqual(expected, circle.Area);
        }
        [TestMethod]
        public void Circle_CalculateArea_SetValue()
        {
            // Arrange
            var circle = new Circle(10);
            var expected = (decimal)Math.PI * 25;
            // Act
            circle.Radius.Size = 5;
            // Assert
            Assert.AreEqual(expected, circle.Area);
        }
    }
}