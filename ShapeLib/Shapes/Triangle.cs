using ShapeLib.Base;
using ShapeLib.Simple;

namespace ShapeLib.Shapes
{
    public class Triangle : Polygon
    {

        public Triangle(Side[] sides) : base(sides)
        {
        }
        /// <summary>
        /// Triangle has three sides :)
        /// </summary>
        public override int CountSides => 3;
        /// <summary>
        /// Calculate area of triangle by formula:<br/>
        /// semiperimeter = (a + b + c) / 2 <br/>
        /// Area = Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c))
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateArea()
        {
            var semiperimeter = Sides.Sum(s => s.Size) / 2;
            return (decimal)Math.Sqrt((double)(
                semiperimeter
                * (semiperimeter - Sides[0].Size)
                * (semiperimeter - Sides[1].Size)
                * (semiperimeter - Sides[2].Size)
                ));
        }
        /// <summary>
        /// Check can exist triangle. <br/>
        /// Every sum of two sides must be more than third side.
        /// </summary>
        /// <returns>Can exist</returns>
        public override bool CanExist()
        {
            return Sides[0].Size + Sides[1].Size > Sides[2].Size
                & Sides[0].Size + Sides[2].Size > Sides[1].Size
                & Sides[1].Size + Sides[2].Size > Sides[0].Size;
        }
        /// <summary>
        /// Check is right triangle by formula: <br/>
        /// maxSide^2 + maxSide^2 == a^2 * b^2 + c^2
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            var maxSide = Sides.Max(s => s.Size);
            return maxSide * maxSide + maxSide * maxSide ==
                Sides[0].Size * Sides[0].Size
                + Sides[1].Size * Sides[1].Size
                + Sides[2].Size * Sides[2].Size;
        }
    }
}
