namespace nspacelib.Geometry
{
    using System;

    /// <summary>
    /// The rectangle is a quad with four right angles.
    /// </summary>
    public class Rectangle : Quad
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="a">
        /// The length of side A of the rectangle.
        /// </param>
        /// <param name="b">
        /// The height of side B of the rectangle.
        /// </param>
        /// <exception cref="ArgumentException">
        /// If any of the sides is zero, an <see cref="ArgumentException"/> is thrown.
        /// </exception>
        public Rectangle(double a, double b)
        {
            if (a.Equals(0.0))
            {
                throw new ArgumentException("A side of a rectangle cannot be zero.", "a");
            }

            if (b.Equals(0.0))
            {
                throw new ArgumentException("A side of a rectangle cannot be zero.", "b");
            }

            this.A = a;
            this.B = b;
        }

        /// <summary>
        /// Gets or sets the length of side A.
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Gets or sets the length of side B.
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Gets the area of the rectangle.
        /// </summary>
        public override double Area
        {
            get { return this.A * this.B; }
        }

        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        public override double Perimeter
        {
            get { return 2.0 * (this.A + this.B); }
        }

        /// <summary>
        /// Gets the length of the diagonal.
        /// </summary>
        public double Diagonal
        {
            get { return Math.Sqrt((this.A * this.A) + (this.B * this.B)); }
        }
    }
}
