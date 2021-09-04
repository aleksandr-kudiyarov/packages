using Kudiyarov.DoubleExtensions.Constants;
using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests
{
    public class LessThanOrEqualTests : BaseDoubleExtensionsTest
    {
        [Fact]
        public void ZeroLessThanOrEqualTolerance()
        {
            var result = Zero.LessThanOrEqual(Constants.Tolerance);
            Assert.True(result);
        }
        
        [Fact]
        public void ToleranceNotLessThanOrEqualZero()
        {
            var result = Constants.Tolerance.LessThanOrEqual(Zero);
            Assert.False(result);
        }
        
        [Fact]
        public void AddLessThanOrEqualMultiply()
        {
            var result = Add.LessThanOrEqual(Multiply);
            Assert.True(result);
        }
        
        [Fact]
        public void MultiplyLessThanOrEqualAdd()
        {
            var result = Multiply.LessThanOrEqual(Add);
            Assert.True(result);
        }
    }
}