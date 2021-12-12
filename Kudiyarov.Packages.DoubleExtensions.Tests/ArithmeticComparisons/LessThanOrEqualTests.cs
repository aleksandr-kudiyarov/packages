using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons;

public class LessThanOrEqualTests : BaseArithmeticComparisonsTest
{
    [Fact]
    public void ZeroLessThanOrEqualTolerance()
    {
        var result = Zero.LessThanOrEqual(Tolerance);
        Assert.True(result);
    }

    [Fact]
    public void ToleranceLessThanOrEqualZero()
    {
        var result = Tolerance.LessThanOrEqual(Zero);
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