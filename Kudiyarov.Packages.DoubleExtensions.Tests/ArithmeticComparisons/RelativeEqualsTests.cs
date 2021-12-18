using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons;

public class RelativeEqualsTests : BaseArithmeticComparisonsTest
{
    [Fact]
    public void AddEqualMultiply()
    {
        var result = Add.RelativeEquals(Multiply);
        Assert.True(result);
    }

    [Fact]
    public void MultiplyEqualAdd()
    {
        var result = Add.RelativeEquals(Multiply);
        Assert.True(result);
    }

    [Theory]
    [InlineData(Tolerance)]
    [InlineData(-Tolerance)]
    public void ToleranceEqualZero(double tolerance)
    {
        var result = tolerance.RelativeEquals(Zero);
        Assert.False(result);
    }

    [Theory]
    [InlineData(Tolerance)]
    [InlineData(-Tolerance)]
    public void ZeroEqualTolerance(double tolerance)
    {
        var result = Zero.RelativeEquals(tolerance);
        Assert.False(result);
    }
}