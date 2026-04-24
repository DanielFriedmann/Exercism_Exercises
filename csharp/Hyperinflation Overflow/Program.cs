public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            return $"{checked(@base * multiplier)}";
        }

        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        if (!float.IsInfinity(@base * multiplier)) return $"{@base * multiplier}";
        else return "*** Too Big ***";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            return $"{salaryBase * multiplier}";
        }

        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
