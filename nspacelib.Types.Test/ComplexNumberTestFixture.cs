namespace nspacelib.Types.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class ComplexNumberTestFixture
    {
        [Test]
        public void VerifyThatParseWorks()
        {
            var statement1 = "1+2i";
            var statement2 = "1-2i";
            var statement3 = "-1+2i";
            var statement4 = "-1-2i";
            var statement5 = "-3";
            var statement6 = "4i";
            var statement7 = "-4i";

            ComplexNumber parsed1;
            ComplexNumber parsed2;
            ComplexNumber parsed3;
            ComplexNumber parsed4;
            ComplexNumber parsed5;
            ComplexNumber parsed6;
            ComplexNumber parsed7;

            Assert.IsTrue(ComplexNumber.TryParse(statement1, out parsed1));
            Assert.IsTrue(ComplexNumber.TryParse(statement2, out parsed2));
            Assert.IsTrue(ComplexNumber.TryParse(statement3, out parsed3));
            Assert.IsTrue(ComplexNumber.TryParse(statement4, out parsed4));
            Assert.IsTrue(ComplexNumber.TryParse(statement5, out parsed5));
            Assert.IsTrue(ComplexNumber.TryParse(statement6, out parsed6));
            Assert.IsTrue(ComplexNumber.TryParse(statement7, out parsed7));
        }
    }
}
