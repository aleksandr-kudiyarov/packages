using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons;

public class EqualTests : BaseArithmeticComparisonsTest
{
    [Fact]
    public void AddEqualMultiply()
    {
        var result = Add.Equal(Multiply);
        Assert.True(result);
    }

    [Fact]
    public void MultiplyEqualAdd()
    {
        var result = Add.Equal(Multiply);
        Assert.True(result);
    }

    [Theory]
    [InlineData(Tolerance)]
    [InlineData(-Tolerance)]
    public void ToleranceEqualZero(double tolerance)
    {
        var result = tolerance.Equal(Zero);
        Assert.False(result);
    }

    [Theory]
    [InlineData(Tolerance)]
    [InlineData(-Tolerance)]
    public void ZeroEqualTolerance(double tolerance)
    {
        var result = Zero.Equal(tolerance);
        Assert.False(result);
    }
}