namespace nspacelib.Geometry
{
    /// <summary>
    /// The 2DPrimitive interface.
    /// </summary>
    public interface I2DPrimitive : I2DShape
    {
        /// <summary>
        /// Gets the number of vertices.
        /// </summary>
        int NumberOfVertices { get; }
    }
}
