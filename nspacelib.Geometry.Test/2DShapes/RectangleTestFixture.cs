namespace nspacelib.Geometry.Test
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RectangleTestFixture
    {
        private Rectangle rectangle;

        [SetUp]
        public void SetUp()
        {
            this.rectangle = new Rectangle(2.0, 3.0);
        }

        [Test]
        public void VerifySides()
        {
            Assert.AreEqual(4, this.rectangle.NumberOfVertices);

            Assert.AreEqual(2, this.rectangle.A);
            Assert.AreEqual(3, this.rectangle.B);
        }

        [Test]
        public void VerifyArea()
        {
            Assert.AreEqual(6, this.rectangle.Area);
        }

        [Test]
        public void VerifyPerimeter()
        {
            Assert.AreEqual(10, this.rectangle.Perimeter);
        }

        [Test]
        public void VerifyDiagonal()
        {
            Assert.AreEqual(Math.Sqrt(13), this.rectangle.Diagonal);
        }
    }
}
