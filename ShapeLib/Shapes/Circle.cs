using ShapeLib.Base;
using ShapeLib.Simple;

namespace ShapeLib.Shapes
{
    public class Circle : BaseShape
    {
        /// <summary>
        /// Radius can be changed. <br/>
        /// Area will auto recalculate if change radius
        /// </summary>
        public Side Radius { get; set; }

        public Circle(decimal radius)
        {
            Radius = new Side(radius);
            Radius.SizeChanged += () => _area = CalculateArea();
            _area = CalculateArea();
        }
        /// <summary>
        /// Calculate area by formula π*R^2
        /// </summary>
        /// <returns>Area</returns>
        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * Radius.Size * Radius.Size;
        }
    }
}
