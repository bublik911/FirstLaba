namespace RationalNumber.Test
{
    public class Tests
    {

        [Test]
        [TestCase(1, 2, 3, 4, 5, 4)]
        [TestCase(1, 2, 1, 2, 1, 1)]
        [TestCase(40, 100, 5, 10, 9, 10)]
        [TestCase(5, 4, 6, 9, 23, 12)]
        [TestCase(0, 2, 2, 1, 2, 1)]
        public void SumTest(int a, int b, int c, int d, int resultNum, int resultDenom)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            var result = first + second;

            Assert.That(result.Numerator == resultNum, Is.True);
            Assert.That(result.Denominator == resultDenom, Is.True);
        }

        [Test]
        [TestCase(1, 2, 3, 4, -1, 4)]
        [TestCase(1, 2, 1, 2, 0, 1)]
        [TestCase(40, 100, 5, 10, -1, 10)]
        [TestCase(5, 4, 6, 9, 7, 12)]
        [TestCase(0, 2, 2, 1, -2, 1)]
        public void SubTest(int a, int b, int c, int d, int resultNum, int resultDenom)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            var result = first - second;

            Assert.That(result.Numerator == resultNum, Is.True);
            Assert.That(result.Denominator == resultDenom, Is.True);
        }

        [Test]
        [TestCase(1, 2, 3, 4, 2, 3)]
        [TestCase(1, 2, 1, 2, 1, 1)]
        [TestCase(40, 100, 5, 10, 4, 5)]
        [TestCase(5, 4, 6, 9, 15, 8)]
        [TestCase(0, 2, 2, 1, 0, 1)]
        public void DivideTest(int a, int b, int c, int d, int resultNum, int resultDenom)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            var result = first / second;

            Assert.That(result.Numerator == resultNum, Is.True);
            Assert.That(result.Denominator == resultDenom, Is.True);
        }

        [Test]
        [TestCase(1, 2, 3, 4, 3, 8)]
        [TestCase(1, 2, 1, 2, 1, 4)]
        [TestCase(40, 100, 5, 10, 1, 5)]
        [TestCase(5, 4, 6, 9, 5, 6)]
        [TestCase(0, 2, 2, 1, 0, 1)]
        public void MultiplyTest(int a, int b, int c, int d, int resultNum, int resultDenom)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            var result = first * second;

            Assert.That(result.Numerator == resultNum, Is.True);
            Assert.That(result.Denominator == resultDenom, Is.True);
        }

        [Test]
        [TestCase(-1, 2, 1, 2)]
        [TestCase(0, 2, 0, 1)]
        [TestCase(1, -2, 1, 2)]
        [TestCase(1, 2, -1, 2)]
        [TestCase(-1, -2, -1, 2)]
        public void NotTest(int a, int b, int resultNum, int resultDenom)
        {
            var first = new RationalNumber(a, b);

            var result = -first;

            Assert.That(result.Numerator == resultNum, Is.True);
            Assert.That(result.Denominator == resultDenom, Is.True);
        }

        [Test]
        [TestCase(0, 2, "0")]
        [TestCase(1, -2, "-1/2")]
        [TestCase(2, 2, "1")]
        [TestCase(-20, 2, "-10")]
        [TestCase(-3, 4, "-3/4")]
        public void ToStringTest(int a, int b, string result)
        {
            var first = new RationalNumber(a, b);

            var str = first.ToString();

            Assert.IsTrue(str == result);
        }

        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(4, 2, 6, 3, true)]
        [TestCase(-1, 2, 2, 4, false)]
        [TestCase(4, 2, 2, 1, true)]
        [TestCase(1, 2, 0, 4, false)]
        public void EqualTest(int a, int b, int c, int d, bool result)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            Assert.That((first == second) == result, Is.True);
        }

        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(4, 2, 6, 3, false)]
        [TestCase(-1, 2, 2, 4, true)]
        [TestCase(4, 2, 2, 1, false)]
        [TestCase(1, 2, 0, 4, true)]
        public void NonEqualTest(int a, int b, int c, int d, bool result)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            Assert.That((first != second) == result, Is.True);
        }

        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(4, 2, 6, 3, false)]
        [TestCase(-1, 2, 2, 4, false)]
        [TestCase(4, 2, 2, 1, false)]
        [TestCase(1, 2, 0, 4, true)]
        public void BiggerTest(int a, int b, int c, int d, bool result)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            Assert.That((first > second) == result, Is.True);
        }

        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(4, 2, 6, 3, false)]
        [TestCase(-1, 2, 2, 4, true)]
        [TestCase(4, 2, 2, 1, false)]
        [TestCase(1, 2, 0, 4, false)]
        public void SmallerTest(int a, int b, int c, int d, bool result)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            Assert.That((first < second) == result, Is.True);
        }

        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(4, 2, 6, 3, true)]
        [TestCase(-1, 2, 2, 4, true)]
        [TestCase(4, 2, 2, 1, true)]
        [TestCase(1, 2, 0, 4, false)]
        public void SmallerOrEqualTest(int a, int b, int c, int d, bool result)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            Assert.That((first <= second) == result, Is.True);
        }

        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(4, 2, 6, 3, true)]
        [TestCase(-1, 2, 2, 4, false)]
        [TestCase(4, 2, 2, 1, true)]
        [TestCase(1, 2, 0, 4, true)]
        public void BiggerOrEqualTest(int a, int b, int c, int d, bool result)
        {
            var first = new RationalNumber(a, b);
            var second = new RationalNumber(c, d);

            Assert.That((first >= second) == result, Is.True);
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, 0)]
        [TestCase(1, -0)]
        public void Test_non_zero(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => new RationalNumber(a, b));
        }
    }
}