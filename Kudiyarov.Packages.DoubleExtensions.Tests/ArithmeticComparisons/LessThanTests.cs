using Kudiyarov.DoubleExtensions.Constants;
using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons
{
    public class LessThanTests : BaseArithmeticComparisonsTest
    {
        [Fact]
        public void ZeroLessThanTolerance()
        {
            var result = Zero.LessThan(Constants.Tolerance);
            Assert.True(result);
        }
        
        [Fact]
        public void ToleranceLessThanZero()
        {
            var result = Constants.Tolerance.LessThan(Zero);
            Assert.False(result);
        }
        
        [Fact]
        public void AddLessThanMultiply()
        {
            var result = Add.LessThan(Multiply);
            Assert.False(result);
        }
        
        [Fact]
        public void MultiplyLessThanAdd()
        {
            var result = Multiply.LessThan(Add);
            Assert.False(result);
        }
    }
}