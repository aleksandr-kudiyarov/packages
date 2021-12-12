using Kudiyarov.Packages.DoubleExtensions.Common;

namespace Kudiyarov.Packages.DoubleExtensions;

public static class DoubleExtensions
{
    public static bool Equal(this double x, double y)
    {
        var diff = x - y;
        var result = LessThanTolerance(diff);
        return result;
    }

    public static bool LessThan(this double x, double y)
    {
        var diff = x - y;
        var result = diff < 0 && !LessThanTolerance(diff);
        return result;
    }

    public static bool LessThanOrEqual(this double x, double y)
    {
        var diff = x - y;
        var result = diff < 0 || LessThanTolerance(diff);
        return result;
    }

    public static bool MoreThan(this double x, double y)
    {
        var diff = x - y;
        var result = diff > 0 && !LessThanTolerance(diff);
        return result;
    }

    public static bool MoreThanOrEqual(this double x, double y)
    {
        var diff = x - y;
        var result = diff > 0 || LessThanTolerance(diff);
        return result;
    }

    public static double RoundTo(this double value, double factor)
    {
        var result = Math.Round(value / factor, MidpointRounding.AwayFromZero) * factor;
        return result;
    }

    private static bool LessThanTolerance(double value)
    {
        var abs = Math.Abs(value);
        var result = abs < Constants.Tolerance;
        return result;
    }
}