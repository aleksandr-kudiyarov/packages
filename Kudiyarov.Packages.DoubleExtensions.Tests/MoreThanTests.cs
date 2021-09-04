using Kudiyarov.DoubleExtensions.Constants;
using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests
{
    public class MoreThanTests : BaseDoubleExtensionsTest
    {
        [Fact]
        public void ToleranceMoreThanZero()
        {
            var result = Constants.Tolerance.MoreThan(Zero);
            Assert.True(result);
        }
        
        [Fact]
        public void ZeroMoreThanTolerance()
        {
            var result = Zero.MoreThan(Constants.Tolerance);
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