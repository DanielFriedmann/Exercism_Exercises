public static class Grains
{
    public static ulong Square(int n)
    {
        if (n > 0 && n < 65)
        {
            ulong grains = 1;
            for (int i = 2; i <= n; i++)
            {
                grains *= 2;
            }
            return grains;
        }
        else throw new ArgumentOutOfRangeException();
    }

    public static ulong Total()
    {
        ulong grains = 1;
        ulong total = 0;
        for (int i = 1; i <= 64; i++)
        {
            total += grains;
            grains *= 2;
        }
        return total;
    }
}