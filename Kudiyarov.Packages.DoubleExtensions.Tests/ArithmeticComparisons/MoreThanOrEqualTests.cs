using Kudiyarov.DoubleExtensions.Constants;
using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons
{
    public class MoreThanOrEqualTests : BaseArithmeticComparisonsTest
    {
        [Fact]
        public void ToleranceMoreThanOrEqualZero()
        {
            var result = Constants.Tolerance.MoreThanOrEqual(Zero);
            Assert.True(result);
        }
        
        [Fact]
        public void ZeroMoreThanOrEqualTolerance()
        {
            var result = Zero.MoreThanOrEqual(Constants.Tolerance);
            Assert.False(result);
        }
        
        [Fact]
        public void AddMoreThanOrEqualMultiply()
        {
            var result = Add.MoreThanOrEqual(Multiply);
            Assert.True(result);
        }
        
        [Fact]
        public void MultiplyMoreThanOrEqualAdd()
        {
            var result = Multiply.MoreThanOrEqual(Add);
            Assert.True(result);
        }
    }
}