using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests
{
    public class RoundToTests : BaseDoubleExtensionsTest
    {
        [Theory]
        [InlineData(1, 2.5, 0)]
        [InlineData(1.25, 2.5, 2.5)]
        [InlineData(2, 2.5, 2.5)]
        public void ToleranceEqualZero(double value, double factor, double expected)
        {
            var actual = value.RoundTo(factor);
            Assert.Equal(expected, actual);
        }
    }
}