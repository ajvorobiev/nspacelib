namespace nspacelib.Geometry
{
    /// <summary>
    /// The 2DShape interface.
    /// </summary>
    public interface I2DShape
    {
        /// <summary>
        /// Gets the area of the shape.
        /// </summary>
        double Area { get; }

        /// <summary>
        /// Gets the perimeter of the shape.
        /// </summary>
        double Perimeter { get; }
    }
}
