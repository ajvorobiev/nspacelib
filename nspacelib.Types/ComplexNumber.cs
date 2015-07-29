namespace nspacelib.Types
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// The complex number.
    /// </summary>
    public class ComplexNumber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexNumber"/> class.
        /// </summary>
        /// <param name="real">
        /// The real part.
        /// </param>
        /// <param name="imaginary">
        /// The imaginary part.
        /// </param>
        public ComplexNumber(double real, double imaginary)
        {
            this.Re = real;
            this.Im = imaginary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexNumber"/> class.
        /// </summary>
        public ComplexNumber()
        {
            this.Re = 0;
            this.Im = 0;
        }

        /// <summary>
        /// Gets or sets the real part.
        /// </summary>
        public double Re { get; set; }

        /// <summary>
        /// Gets or sets the imaginary part.
        /// </summary>
        public double Im { get; set; }

        /// <summary>
        /// String representation of the complex number.
        /// </summary>
        /// <returns>The string representatgion of the complex number.</returns>
        public override string ToString()
        {
            if (this.Im.Equals(0.0))
            {
                return string.Format("{0}", this.Re);
            }

            if (this.Im < 0.0)
            {
                return string.Format("{0}{1}i", this.Re, this.Im);
            }

            return string.Format("{0}+{1}i", this.Re, this.Im);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((ComplexNumber)obj);
        }

        /// <summary>
        /// Returns the Equality when the type is correct.
        /// </summary>
        /// <param name="other">
        /// The other object.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/> indicating equality.
        /// </returns>
        protected bool Equals(ComplexNumber other)
        {
            return this.Re.Equals(other.Re) && this.Im.Equals(other.Im);
        }

        /// <summary>
        /// Gets the Hash code.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/> representing the hash code.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (this.Re.GetHashCode() * 397) ^ this.Im.GetHashCode();
            }
        }

        /// <summary>
        /// Parses a complex number string into a <see cref="ComplexNumber"/> object.
        /// </summary>
        /// <param name="statement">
        /// The statement to parse.
        /// </param>
        /// <returns>
        /// The <see cref="ComplexNumber"/> parsed from the string. Null is parsing failed.
        /// </returns>
        public static ComplexNumber Parse(string statement)
        {
            var pattern = @"(^([-]?[\d]+))?(([+-]+)([\d]+)?i)?";

            if (Regex.IsMatch(statement, pattern))
            {
                var number = new ComplexNumber();
                var matches = Regex.Match(statement, pattern);

                if (matches.Captures.Count != 0)
                {
                    // imaginary part is present
                    if (matches.Captures.Count > 2)
                    {
                        // imaginary operator
                        var imSign = matches.Captures[3].Value;

                        if (matches.Captures.Count > 4)
                        {
                            // imaginary part
                            double imPart;
                            if (!double.TryParse(matches.Captures[4].Value, out imPart))
                            {
                                return null;
                            }

                            number.Im = imPart;
                        }
                        else
                        {
                            number.Im = 1;
                        }

                        if (imSign == "-")
                        {
                            number.Im *= -1;
                        }
                        
                    }
                    

                    // real part is present
                }
            }

            return null;
        }
    }
}
