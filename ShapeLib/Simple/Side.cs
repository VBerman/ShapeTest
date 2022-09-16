namespace ShapeLib.Simple
{
    /// <summary>
    /// Helps to work Polygon.
    /// </summary>
    public class Side
    {
        private decimal _size;
        /// <summary>
        /// Size of side. <br/>
        /// Invoke after set value. <br/>
        /// </summary>
        /// <exception cref="ArgumentException">Size of side can't be less 0</exception>
        public decimal Size
        {
            get { return _size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size of side can't be less 0");
                }
                _size = value;
                SizeChanged.Invoke();
            }
        }

        public Side(decimal size)
        {
            Size = size;
        }
        /// <summary>
        /// Need to track changes of side. 
        /// </summary>
        public event Action SizeChanged = () => { };
    }
}
