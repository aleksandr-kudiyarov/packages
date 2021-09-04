using Kudiyarov.DoubleExtensions.Constants;
using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons
{
    public class EqualTests : BaseArithmeticComparisonsTest
    {
        [Fact]
        public void AddEqualMultiply()
        {
            var result = Add.Equal(Multiply);
            Assert.True(result);
        }
        
        [Theory]
        [InlineData(Constants.Tolerance)]
        [InlineData(-Constants.Tolerance)]
        public void ToleranceEqualZero(double tolerance)
        {
            const double zero = 0;
            var result = zero.Equal(tolerance);
            Assert.False(result);
        }
    }
}