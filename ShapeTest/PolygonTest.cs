using ShapeLib.Base;
using ShapeLib.Shapes;
using ShapeLib.Simple;

namespace ShapeTest
{
    [TestClass]
    public class PolygonTest
    {
        [TestMethod]
        public void Polygon_SetAllSides()
        {
            // Arrange
            Polygon polygon = new Triangle(new Side[] { new Side(3), new Side(4), new Side(3) });
            decimal expected = 6;
            // Act
            polygon.SetAllSides(new Side[] { new Side(3), new Side(4), new Side(5) });
            // Assert  
            Assert.AreEqual(expected, polygon.Area);
        }

    }
}