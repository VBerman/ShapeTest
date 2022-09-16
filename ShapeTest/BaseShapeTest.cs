using ShapeLib.Base;
using ShapeLib.Shapes;
using ShapeLib.Simple;

namespace ShapeTest
{
    [TestClass]
    public class BaseShapeTest
    {
        [TestMethod]
        public void BaseShape_CheckArea_InCompileTime_Triangle()
        {
            // Arrange & act
            BaseShape baseShape = new Triangle(new Side[] { new Side(3), new Side(4), new Side(5) });
            decimal expected = 6;
            // Assert  
            Assert.AreEqual(expected, baseShape.Area);
        }
        [TestMethod]
        public void BaseShape_CheckArea_InCompileTime_Circle()
        {
            // Arrange & act
            BaseShape baseShape = new Circle(10);
            var expected = (decimal)Math.PI * 100;
            // Assert 
            Assert.AreEqual(expected, baseShape.Area);
        }

    }
}