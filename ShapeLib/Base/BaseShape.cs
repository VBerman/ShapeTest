
namespace ShapeLib.Base
{
    /// <summary>
    /// Needed to inherit all future shapes
    /// </summary>
    public abstract class BaseShape
    {
        /// <summary>
        /// Need for hiding. Area can't changed from outside.
        /// </summary>
        private protected decimal _area;
        /// <summary>
        /// Return area of shape.
        /// </summary>
        public decimal Area => _area;
        /// <summary>
        /// If future realization don't will have
        /// auto calculation of area, we can
        /// take value from this method
        /// </summary>
        /// <returns>Area of shape</returns>
        public abstract decimal CalculateArea();
    }
}
