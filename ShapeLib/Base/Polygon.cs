
using ShapeLib.Simple;

namespace ShapeLib.Base
{
    /// <summary>
    /// Need for polygonal shapes. Implied that user know all sides of shape.
    /// </summary>
    public abstract class Polygon : BaseShape
    {
        /// <summary>
        /// Necessary to avoid errors due to the size of the array of sides
        /// </summary>
        public abstract int CountSides { get; }
        /// <summary>
        /// Array of figure sides
        /// </summary>
        public readonly Side[] Sides;

        public Polygon(Side[] sides)
        {
            Sides = new Side[CountSides];
            SetAllSides(sides);
        }
        /// <summary>
        /// This method need for init sides in Polygon.<br/>
        /// Virtual for various implementation 
        /// (somebody don't want to check the possibility of such a shape)
        /// </summary>
        /// <param name="sides">Length array of sides need equal to CountSides</param>
        /// <exception cref="ArgumentException">Count of sides need be equal to CountSides of Polygon</exception>
        public virtual void SetAllSides(Side[] sides)
        {
            if (sides.Length != CountSides) throw new ArgumentException("Count of sides need be equal to CountSides of Polygon");
            sides.CopyTo(Sides, 0);
            foreach (var item in Sides)
            {
                item.SizeChanged += () =>
                {
                    CheckValid();
                    _area = CalculateArea();
                };
            }
            CheckValid();
            _area = CalculateArea();
        }
        /// <summary>
        /// Need for avoid code repeat.
        /// </summary>
        /// <exception cref="ArgumentException">Figure can't exist with input sides</exception>
        private void CheckValid()
        {
            if (!CanExist()) throw new ArgumentException("This figure can't exist with input sides");
        }
        /// <summary>
        /// Need for implementation check possibility exist shape. <br/>
        /// This method don't throw exception because it will break logic.
        /// </summary>
        /// <returns>Can exist shape with input sides or not </returns>
        public abstract bool CanExist();

    }
}
