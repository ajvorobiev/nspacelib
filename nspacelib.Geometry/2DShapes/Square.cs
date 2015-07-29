namespace nspacelib.Geometry
{
    /// <summary>
    /// The square is a specialization of the <see cref="Rectangle"/> with all sides being equal.
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="a">
        /// The length of a side of the square
        /// </param>
        public Square(double a) : base(a, a)
        {
        }
    }
}
