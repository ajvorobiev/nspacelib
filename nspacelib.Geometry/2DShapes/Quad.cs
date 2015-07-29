namespace nspacelib.Geometry
{
    /// <summary>
    /// The basic geometric shape with 4 vertices.
    /// </summary>
    public abstract class Quad : I2DPrimitive
    {
        /// <summary>
        /// Gets the area.
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Gets the number of vertices.
        /// </summary>
        public int NumberOfVertices
        {
            get { return 4; }
        }
    }
}
