using ShapeLib.Shapes;
using ShapeLib.Simple;

namespace ShapeTest
{
    [TestClass]
    public class SideTest
    {
        [TestMethod]
        public void Side_Size_SizeChanged()
        {
            // Arrange
            var side = new Side(10);
            var excepted = 5;
            var result = 0;
            // Act
            side.SizeChanged += () => result = 5;
            side.Size = 15;
            // Assert
            Assert.AreEqual(excepted, result);
        }
        [TestMethod]
        public void Side_Size_Exception_FromCtor()
        {
            // Arrange & act & assert 
            Assert.ThrowsException<ArgumentException>(() => new Side(-1));
        }
        [TestMethod]
        public void Side_Size_Exception()
        {
            // Arrange
            var side = new Side(5);
            // Act & Assert 
            Assert.ThrowsException<ArgumentException>(() => side.Size = 0);
        }

       
       
    }
}