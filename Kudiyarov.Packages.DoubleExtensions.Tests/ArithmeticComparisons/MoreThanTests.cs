using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons
{
    public class MoreThanTests : BaseArithmeticComparisonsTest
    {
        [Fact]
        public void ToleranceMoreThanZero()
        {
            var result = Tolerance.MoreThan(Zero);
            Assert.True(result);
        }

        [Fact]
        public void ZeroMoreThanTolerance()
        {
            var result = Zero.MoreThan(Tolerance);
            Assert.False(result);
        }

        [Fact]
        public void AddMoreThanMultiply()
        {
            var result = Add.MoreThan(Multiply);
            Assert.False(result);
        }

        [Fact]
        public void MultiplyMoreThanAdd()
        {
            var result = Multiply.MoreThan(Add);
            Assert.False(result);
        }
    }
}