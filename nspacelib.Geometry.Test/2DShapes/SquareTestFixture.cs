namespace nspacelib.Geometry.Test
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SquareTestFixture
    {
        private Square square;

        [SetUp]
        public void SetUp()
        {
            this.square = new Square(2.0);
        }

        [Test]
        public void VerifySides()
        {
            Assert.AreEqual(4, this.square.NumberOfVertices);

            Assert.AreEqual(2, this.square.A);
            Assert.AreEqual(2, this.square.B);
        }

        [Test]
        public void VerifyArea()
        {
            Assert.AreEqual(4, this.square.Area);
        }

        [Test]
        public void VerifyPerimeter()
        {
            Assert.AreEqual(8, this.square.Perimeter);
        }

        [Test]
        public void VerifyDiagonal()
        {
            Assert.AreEqual(Math.Sqrt(8), this.square.Diagonal);
        }
    }
}
