using Kudiyarov.Packages.DoubleExtensions.Common;

namespace Kudiyarov.Packages.DoubleExtensions.Tests.ArithmeticComparisons;

public abstract class BaseArithmeticComparisonsTest
{
    protected const double Tolerance = Constants.Tolerance;
    protected const double Zero = 0;
    protected readonly double Add;
    protected readonly double Multiply;

    protected BaseArithmeticComparisonsTest()
    {
        Add = GetAddResult();
        Multiply = GetMultiplyResult();
    }

    private static double GetAddResult()
    {
        double add = 0;

            for (var i = 1; i <= 11; i++)
            {
                add += 0.1;
            }

        return add;
    }

    private static double GetMultiplyResult()
    {
        return 0.1 * 11;
    }
}